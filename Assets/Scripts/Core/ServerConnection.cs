using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ServerConnection : MonoBehaviour
{
    [SerializeField]
    private string serviceName;

    public string GetSeviceName => serviceName;

    public UnityEvent<string> ServerCallback;

    private void OnEnable()
    {
        NetworkManager.Instance.GetServermessage(serviceName + ".php", ServerCallback);
    }


}
