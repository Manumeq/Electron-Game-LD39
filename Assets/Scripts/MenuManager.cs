using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void startButton()
    {
        SceneManager.LoadScene("Main");
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

}
