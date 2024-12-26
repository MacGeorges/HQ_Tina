using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ServerConnection : MonoBehaviour
{
    [SerializeField]
    private string serviceName;

    [SerializeField]
    private bool getDataOnEnable;

    [SerializeField]
    private  bool getDataOnUpdate;

    [SerializeField]
    private float getDataOnUpdateInterval;
    private float currentUpdateInterval;

    public string GetSeviceName => serviceName;

    public UnityEvent<string> ServerCallback;

    private void OnEnable()
    {
        if(getDataOnEnable)
        {
            NetworkManager.Instance.GetServermessage(serviceName + ".php", ServerCallback);
        }
    }

    private void Update()
    {
        if(getDataOnUpdate)
        {
            currentUpdateInterval += Time.deltaTime;

            if(currentUpdateInterval >= getDataOnUpdateInterval)
            {
                NetworkManager.Instance.GetServermessage(serviceName + ".php", ServerCallback);
                currentUpdateInterval = 0;
            }
        }
    }
}
