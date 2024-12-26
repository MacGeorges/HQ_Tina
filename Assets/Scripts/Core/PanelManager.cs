 using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class PanelManager : MonoBehaviour
{
    [SerializeField]
    private PanelController startpanel;

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
        Initialization();
    }

    private void Initialization()
    {
        foreach(PanelController panel in panels)
        {
            panel.gameObject.SetActive(panel == startpanel);
        }
    }
}
