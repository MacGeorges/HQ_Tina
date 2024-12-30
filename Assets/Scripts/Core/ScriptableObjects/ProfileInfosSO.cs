using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProfileInfosSO : ScriptableObject
{
    [SerializeField]
    private SkinSO skin;
    
    public List<PanelController> panels;
    public PanelController startPanel;
}
