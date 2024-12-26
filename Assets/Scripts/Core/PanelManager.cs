 using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class PanelManager : MonoBehaviour
{
    [SerializeField]
    private PanelController startPanel;

    //Displayed for debug
    [SerializeField]
    private List<PanelController> panels = new List<PanelController>();

    private PanelController currentPanel;

    public static PanelManager Instance;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        panels = FindObjectsByType<PanelController>(FindObjectsInactive.Include, FindObjectsSortMode.None).ToList();
        Initialization();
    }

    private void Initialization()
    {
        foreach(PanelController panel in panels)
        {
            panel.gameObject.SetActive(panel == startPanel);
            currentPanel = startPanel;
        }
    }

    public void SwitchPanel(PanelController newPanel)
    {
        if(newPanel == currentPanel){return;}

        currentPanel?.gameObject.SetActive(false);
        newPanel.gameObject.SetActive(true);
        currentPanel = newPanel;
    }
}
