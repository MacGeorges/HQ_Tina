using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileController : MonoBehaviour
{
    public bool OpensPanel;
    [SerializeField]
    private PanelController panelController;

    public void OnTileClicked()
    {
        if(OpensPanel && panelController)
        {

        }
    }
}
