using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour {
    ToolBox toolbox;
    // Use this for initialization
    void Start () {
        toolbox = ToolBox.Instance;
        //-----AQUI DENTRO SI
        Debug.Log("ALGOOOO" + PlayerPrefs.GetInt("multiScore"));
        //-------
        if (PlayerPrefs.GetInt("extraVida") != 0)
        {
            Debug.Log("ALGOOOO" + PlayerPrefs.GetInt("extraVida"));
            toolbox.extraVida = 25;
            GameObject.Find("BUY_BOOST").GetComponent<Button>().interactable = false;
            Debug.Log("ALGOOañlsdkfjañlskdjfOO" + toolbox.extraVida);
        }
        if (PlayerPrefs.GetInt("multiScore") != 0)
        {
            toolbox.multiScore = 3;
            GameObject.Find("BUY_MULTIPLIER").GetComponent<Button>().interactable = false;
        }
        if (PlayerPrefs.GetInt("armadura") != 0)
        {
            toolbox.armadura = 20;
            GameObject.Find("BUY_MAGNET").GetComponent<Button>().interactable = false;
        }
        if (PlayerPrefs.GetInt("acelerado") != 0)
        {
            toolbox.acelerado = 1;
            GameObject.Find("BUY_RELATIVITY").GetComponent<Button>().interactable = false;
        }
        if (PlayerPrefs.GetInt("revivir") != 0)
        {
            toolbox.revivir = 1;
            GameObject.Find("BUY_LAST").GetComponent<Button>().interactable = false;
        }
        if (PlayerPrefs.GetInt("polar") != 0)
        {
            toolbox.polar = 1;
            GameObject.Find("BUY_POLARIZER").GetComponent<Button>().interactable = false;
        }
        GameObject.Find("Money").GetComponent<Text>().text =  toolbox.monedas.ToString();
    }
	
	// Update is called once per frame
	void Update () {
        
        GameObject.Find("Money").GetComponent<Text>().text = toolbox.monedas.ToString();
    }

    public void startButton()
    {
        toolbox = ToolBox.Instance;
        Debug.Log("ALGOOañlsdkfjañlskdjfOO" +toolbox.extraVida);
        SceneManager.LoadScene("Main");
        toolbox.GetComponent<AudioSource>().clip = GameObject.Find("StartButton").GetComponent<AudioSource>().clip;
        toolbox.GetComponent<AudioSource>().Play();
    }

    public void shopButton()
    {
        SceneManager.LoadScene("Tienda");
    }

    public void optionsButton()
    {
        SceneManager.LoadScene("Opciones");
    }

    public void creditsButton()
    {
        SceneManager.LoadScene("Creditos");
    }

    public void returnButton()
    {
        SceneManager.LoadScene("Menu");
    }

    public void exitButton()
    {
        Application.Quit();
    }

    //shop functions
    public void chargeBoostButton()
    {
        if (toolbox.comprarVidaMax())
        {
            GameObject.Find("BUY_BOOST").GetComponent<Button>().interactable = false;
            saveMoney();
            PlayerPrefs.SetInt("extraVida", toolbox.extraVida);
        }
    }

    public void relativityButton()
    {
        if (toolbox.comprarAceleracion())
        {
            GameObject.Find("BUY_RELATIVITY").GetComponent<Button>().interactable = false;
            saveMoney();
            PlayerPrefs.SetInt("acelerado", toolbox.acelerado);
        }
    }

    public void magnetShieldButton()
    {
        if (toolbox.comprarArmadura())
        {
            GameObject.Find("BUY_MAGNET").GetComponent<Button>().interactable = false;
            saveMoney();
            PlayerPrefs.SetInt("armadura", toolbox.armadura);
        }
    }

    public void lastBatteryButton()
    {
        if (toolbox.comprarRevivir())
        {
            GameObject.Find("BUY_LAST").GetComponent<Button>().interactable = false;
            saveMoney();
            PlayerPrefs.SetInt("revivir", toolbox.revivir);
        }
    }

    public void multiplierButton()
    {
        if (toolbox.comprarScore())
        {
            GameObject.Find("BUY_MULTIPLIER").GetComponent<Button>().interactable = false;
            saveMoney();
            PlayerPrefs.SetInt("multiScore", toolbox.multiScore);
        }
    }

    public void polarizerButton()
    {
        if (toolbox.comprarPolarizacion())
        {
            GameObject.Find("BUY_POLARIZER").GetComponent<Button>().interactable = false;
            saveMoney();
            PlayerPrefs.SetInt("polar", toolbox.polar);
        }
    }

    public void saveMoney()
    {
        PlayerPrefs.SetInt("monedas", toolbox.monedas);
    }

}
