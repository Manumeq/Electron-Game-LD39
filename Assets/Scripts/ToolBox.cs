using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToolBox : Singleton<ToolBox> {
    protected ToolBox() { }
    // Use this for initialization
    public string myGlobalVar = "whatever";
    public int puntuacion;
    void Awake()
    {

    }
}

