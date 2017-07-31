using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sliderToText : MonoBehaviour {
    public GameObject bgm;
    public GameObject eff;
    public GameObject bgm_txt;
    public GameObject eff_txt;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        bgm_txt.GetComponent<Text>().text = (bgm.GetComponent<Slider>().value * 100f).ToString("#");
        eff_txt.GetComponent<Text>().text = (eff.GetComponent<Slider>().value * 100f).ToString("#");
    }
}
