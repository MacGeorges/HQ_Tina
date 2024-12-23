using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    [SerializeField]
    private Camera camera;

    public static CameraManager Instance;

    private void Awake()
    {
        Instance = this;
    }
}
