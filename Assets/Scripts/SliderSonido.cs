using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderSonido : MonoBehaviour {
    ToolBox toolbox;
    // Use this for initialization
    void Start () {
        toolbox = ToolBox.Instance;
	}
	
	// Update is called once per frame
	void Update () {
        toolbox.GetComponent<AudioSource>().volume = gameObject.GetComponent<Slider>().value;
	}
}
