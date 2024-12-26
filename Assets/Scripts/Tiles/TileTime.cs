using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TileTime : TileController
{
    [SerializeField]
    private TMP_Text clockText;

    private void Update()
    {
        clockText.text = System.DateTime.Now.ToString();
    }
}
