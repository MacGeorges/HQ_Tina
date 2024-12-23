using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class TileManager : MonoBehaviour
{
    [SerializeField]
    private Transform tilesRoot;

    //Displayed for debug
    [SerializeField]
    private List<TileController> tiles = new List<TileController>();

    private void Start()
    {
        tiles = FindObjectsByType<TileController>(FindObjectsSortMode.None).ToList();
    }
}
