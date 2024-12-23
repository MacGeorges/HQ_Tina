 using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class PanelManager : MonoBehaviour
{
    //Displayed for debug
    [SerializeField]
    private List<PanelController> panels = new List<PanelController>();

    public static PanelManager Instance;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        panels = FindObjectsByType<PanelController>(FindObjectsSortMode.None).ToList();
    }
}
