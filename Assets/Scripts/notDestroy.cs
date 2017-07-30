using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class notDestroy : MonoBehaviour {
    public GameObject volumeBGM;
    public GameObject volumeEFFECTS;
    private Scene main;
    // Use this for initialization
    void Start () {
        DontDestroyOnLoad(gameObject);
        //move();
	}
	
	// Update is called once per frame
	void Update () {
        //volumeBGM = GameObject.Find("Slider_BGM").GetComponent<Slider>().value;
        //volumeEFFECTS = GameObject.Find("Slider_EFFECTS").GetComponent<Slider>().value;

        volumeBGM = GameObject.Find("Slider_BGM");
        volumeEFFECTS = GameObject.Find("Slider_EFFECTS");
        Debug.Log(volumeBGM);

        //gameObject.GetComponent<AudioSource>().volume=volumeBGM;
    }

    private void move()
    {
        /*
        main = SceneManager.GetSceneByName("Main");
        SceneManager.MoveGameObjectToScene(gameObject, main);
        */
    }
}
