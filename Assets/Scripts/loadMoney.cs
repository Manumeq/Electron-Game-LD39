using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loadMoney : MonoBehaviour {
    ToolBox toolbox;
    // Use this for initialization
    void Start () {
        toolbox = ToolBox.Instance;
        toolbox.monedas = PlayerPrefs.GetInt("monedas");
        toolbox.maxPuntuacion = PlayerPrefs.GetInt("maxScore");
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}