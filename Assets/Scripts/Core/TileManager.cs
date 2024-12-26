using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class TileManager : MonoBehaviour
{
    //Displayed for debug
    [SerializeField]
    private List<TileController> tiles = new List<TileController>();

    public static TileManager Instance;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        tiles = FindObjectsByType<TileController>(FindObjectsSortMode.None).ToList();
    }
}
