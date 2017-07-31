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
        if (toolbox.extraVida != 0)
        {
            GameObject.Find("BUY_BOOST").GetComponent<Button>().interactable = false;
        }
        if (toolbox.multiScore != 1)
        {
            GameObject.Find("BUY_MULTIPLIER").GetComponent<Button>().interactable = false;
        }
        if (toolbox.armadura != 0)
        {
            GameObject.Find("BUY_MAGNET").GetComponent<Button>().interactable = false;
        }
        if (toolbox.aceleracion != 0)
        {
            GameObject.Find("BUY_RELATIVITY").GetComponent<Button>().interactable = false;
        }
        if (toolbox.revivir)
        {
            GameObject.Find("BUY_LAST").GetComponent<Button>().interactable = false;
        }
        if (toolbox.polar)
        {
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
        }
    }

    public void relativityButton()
    {
        if (toolbox.comprarAceleracion())
        {
            GameObject.Find("BUY_RELATIVITY").GetComponent<Button>().interactable = false;
        }
    }

    public void magnetShieldButton()
    {
        if (toolbox.comprarArmadura())
        {
            GameObject.Find("BUY_MAGNET").GetComponent<Button>().interactable = false;
        }
    }

    public void lastBatteryButton()
    {
        if (toolbox.comprarRevivir())
        {
            GameObject.Find("BUY_LAST").GetComponent<Button>().interactable = false;
        }
    }

    public void multiplierButton()
    {
        if (toolbox.comprarScore())
        {
            GameObject.Find("BUY_MULTIPLIER").GetComponent<Button>().interactable = false;
        }
    }

    public void polarizerButton()
    {
        if (toolbox.comprarPolarizacion())
        {
            GameObject.Find("BUY_POLARIZER").GetComponent<Button>().interactable = false;
        }
    }

}
