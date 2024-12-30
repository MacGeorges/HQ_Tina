using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class PanelController : MonoBehaviour
{
    [SerializeField]
    private TileController panelTile;
    public TileController PanelTile  => panelTile;

    public void OnGetPanelNetworkmessage(string message)
    {
        Debug.Log(message);
    }
}
