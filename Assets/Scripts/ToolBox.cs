using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
    public bool revivir;
    public bool polar;
    public int maxPuntuacion;
    void Awake()
    {
        gameObject.AddComponent<AudioSource>();
        gameObject.GetComponent<AudioSource>().clip = GameObject.Find("menuOst").GetComponent<AudioSource>().clip;
        gameObject.GetComponent<AudioSource>().loop = true;
        gameObject.GetComponent<AudioSource>().volume = 0.5f;
        gameObject.GetComponent<AudioSource>().Play();
        maxPuntuacion = 0;
        multiScore = 1;
        aceleracion = 0;
        puntuacion = 0;
        sonido = 0.5f;
        armadura = 0;
        extraVida = 0;
        monedas = 99999;
        revivir = false;
        polar = false;
    }

    //9999
    public bool comprarPolarizacion()
    {
        if (monedas > 9999)
        {
            monedas -= 9999;
            polar = true;
            return true;
        }
        else
        {
            return false;
        }
    }
    //400
    public bool comprarAceleracion()//si
    {
        if (monedas > 400)
        {
            monedas -= 400;
            aceleracion = 0.02f;
            return true;
        }
        else
        {
            return false;
        }
    }
    //300
    public bool comprarVidaMax()//si
    {
        if (monedas > 300)
        {
            monedas -= 300;
            extraVida = 25;
            return true;
        }
        else
        {
            return false;
        }
    }
    //1500
    public bool comprarArmadura()//si
    {
        if (monedas > 1500)
        {
            monedas -= 1500;
            armadura = 20;
            return true;
        }
        else
        {
            return false;
        }
    }

    //3000
    public bool comprarScore()
    {
        if (monedas > 3000)
        {
            monedas -= 3000;
            multiScore = 4;
            return true;
        }
        else
        {
            return false;
        }
    }
    //5000
    public bool comprarRevivir()
    {
        if (monedas > 5000)
        {
            monedas -= 5000;
            revivir = true;
            return true;
        }
        else
        {
            return false;
        }
    }
    public void volverAtras()
    {
        monedas += puntuacion / 10;
        if (maxPuntuacion < puntuacion)
        {
            maxPuntuacion = puntuacion;
        }
        SceneManager.LoadScene("Puntuacion");
       
        gameObject.GetComponent<AudioSource>().Stop();
    }

}

