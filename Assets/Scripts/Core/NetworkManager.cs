using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Networking;

public class NetworkManager : MonoBehaviour
{
    [SerializeField]
    private string serverAddress;

    public string GetServerAddress => serverAddress;

    public static NetworkManager Instance;

    private UnityEvent<string> ServerTestCallback = new UnityEvent<string>();

    private void Start()
    {
        Instance = this;


        ServerTestCallback.AddListener(ConnectionTestCallback);
        GetServermessage("ServerTest.php", ServerTestCallback);
    }

    public void GetDirectRequest(string URL, UnityEvent<string> callback)
    {
        StartCoroutine(Connectiontest(URL, callback));
    }

    public void GetServermessage(string service, UnityEvent<string> callback)
    {
        StartCoroutine(Connectiontest(serverAddress + service, callback));
    }

    IEnumerator Connectiontest(string URL, UnityEvent<string> callback)
    {
         using (UnityWebRequest webRequest = UnityWebRequest.Get(URL))
        {
            // Request and wait for the desired page.
            yield return webRequest.SendWebRequest();

            switch (webRequest.result)
            {
                case UnityWebRequest.Result.ConnectionError:
                case UnityWebRequest.Result.DataProcessingError:
                case UnityWebRequest.Result.ProtocolError:
                    callback.Invoke(webRequest.error);
                    break;
                case UnityWebRequest.Result.Success:
                    callback.Invoke(webRequest.downloadHandler.text);
                    break;
            }
        }
    }

    private void ConnectionTestCallback(string message)
    {
        Debug.Log(message);
    }
}
