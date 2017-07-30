using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class notDestroy : MonoBehaviour {
    public float volumeBGM = 0.5f;
    public float volumeEFFECTS = 0.5f;
    // Use this for initialization
    void Start () {
        DontDestroyOnLoad(gameObject);
	}
	
	// Update is called once per frame
	void Update () {
        volumeBGM = GameObject.Find("Slider_BGM").GetComponent<Slider>().value;
        volumeEFFECTS = GameObject.Find("Slider_EFFECTS").GetComponent<Slider>().value;

        gameObject.GetComponent<AudioSource>().volume=volumeBGM;
    }
}
