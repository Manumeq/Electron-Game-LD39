using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class checkShopButtons : MonoBehaviour {

	// Use this for initialization
	void Start () {
        if(PlayerPrefs.GetInt("extraVida")==0)
            GameObject.Find("BUY_BOOST").GetComponent<Button>().interactable = false;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
