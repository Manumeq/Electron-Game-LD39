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
    public bool record;
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
        monedas = 0;
        revivir = false;
        polar = false;
        record = false;
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            monedas = 9999;
        }   
    }
    //2000
    public bool comprarPolarizacion()
    {
        if (monedas >= 2000)
        {
            monedas -= 2000;
            polar = true;
            return true;
        }
        else
        {
            return false;
        }
    }
    //125
    public bool comprarAceleracion()//si
    {
        if (monedas >= 125)
        {
            monedas -= 125;
            aceleracion = 0.02f;
            return true;
        }
        else
        {
            return false;
        }
    }
    //100
    public bool comprarVidaMax()//si
    {
        if (monedas >= 100)
        {
            monedas -= 100;
            extraVida = 25;
            return true;
        }
        else
        {
            return false;
        }
    }
    //500
    public bool comprarArmadura()//si
    {
        if (monedas >= 500)
        {
            monedas -= 500;
            armadura = 20;
            return true;
        }
        else
        {
            return false;
        }
    }

    //1000
    public bool comprarScore()
    {
        if (monedas >= 1000)
        {
            monedas -= 1000;
            multiScore = 4;
            return true;
        }
        else
        {
            return false;
        }
    }
    //1500
    public bool comprarRevivir()
    {
        if (monedas >= 1500)
        {
            monedas -= 1500;
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
            record = true;
        }
        SceneManager.LoadScene("Puntuacion");
        
        gameObject.GetComponent<AudioSource>().Stop();
    }

}

