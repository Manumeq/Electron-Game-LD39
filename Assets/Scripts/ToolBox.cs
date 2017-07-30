using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToolBox : Singleton<ToolBox> {
    protected ToolBox() { }
    // Use this for initialization
    public int puntuacion;
    public float aceleracion;
    public int multiScore;
    void Awake()
    {
        gameObject.AddComponent<AudioSource>();
        gameObject.GetComponent<AudioSource>().clip = GameObject.Find("menuOst").GetComponent<AudioSource>().clip;
        gameObject.GetComponent<AudioSource>().loop = true;
        gameObject.GetComponent<AudioSource>().volume = 0.5f;
        gameObject.GetComponent<AudioSource>().Play();
        multiScore = 1;
        aceleracion = 0;
        puntuacion = 0;
    }

}

