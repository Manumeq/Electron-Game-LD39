using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mostrarPuntuacion : MonoBehaviour {

	// Use this for initialization
	void Start () {
        ToolBox toolbox = ToolBox.Instance;
        gameObject.GetComponent<Text>().text = "Your new score is: " + toolbox.puntuacion;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
