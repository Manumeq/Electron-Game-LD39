using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour {
    ToolBox toolbox;
    // Use this for initialization
    void Start () {
        toolbox = ToolBox.Instance;
    }
	
	// Update is called once per frame
	void Update () {
		
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

    }

    public void relativityButton()
    {

    }

    public void magnetShieldButton()
    {

    }

    public void lastBatteryButton()
    {

    }

    public void multiplierButton()
    {

    }

    public void polarizerButton()
    {

    }

}
