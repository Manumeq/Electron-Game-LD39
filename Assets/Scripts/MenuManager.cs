using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
        ToolBox toolbox = ToolBox.Instance;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void startButton()
    {
        SceneManager.LoadScene("Main");
        ToolBox toolbox = ToolBox.Instance;
        toolbox.GetComponent<AudioSource>().clip = GameObject.Find("StartButton").GetComponent<AudioSource>().clip;
        toolbox.GetComponent<AudioSource>().Play();
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
