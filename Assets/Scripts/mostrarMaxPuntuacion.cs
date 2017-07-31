using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mostrarMaxPuntuacion : MonoBehaviour {

	// Use this for initialization
	void Start () {
        ToolBox toolbox = ToolBox.Instance;
        gameObject.GetComponent<Text>().text = "HighScore: " + toolbox.maxPuntuacion;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
