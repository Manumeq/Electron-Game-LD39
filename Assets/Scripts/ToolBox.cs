using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToolBox : Singleton<ToolBox> {
    protected ToolBox() { }
    // Use this for initialization
    public int puntuacion;
    public float aceleracion;
    public int multiScore;
    public float sonido;
    public int monedas;
    public int armadura;
    public int extraVida;
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
        sonido = 0.5f;
        armadura = 0;
        extraVida = 0;
    }
    public void comprarPolarizacion()
    {

    }
    public void comprarAceleracion()
    {
        aceleracion = 0.02f;
    }
    public void comprarVidaMax()
    {

    }
    public void comprarArmadura()
    {
        armadura = 20;
    }
    public void comprarScore()
    {
        puntuacion = 4;
    }
    public void comprarRevivir()
    {

    }
    public void volverAtras()
    {

    }

}

