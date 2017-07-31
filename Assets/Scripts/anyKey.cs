using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class anyKey : MonoBehaviour {
    ToolBox toolbox;
	// Use this for initialization
	void Start () {
        toolbox = ToolBox.Instance;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.anyKeyDown)
        {
            SceneManager.LoadScene("Menu");
            toolbox.GetComponent<AudioSource>().clip = GameObject.Find("Canvas").GetComponent<AudioSource>().clip;
            toolbox.GetComponent<AudioSource>().Play();
            toolbox.puntuacion = 0;
        }
    }
    
}
