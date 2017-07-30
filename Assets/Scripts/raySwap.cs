using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class raySwap : MonoBehaviour {

    public float segundos;

    public GameObject[] rayitos;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (segundos > 0)
        {
            segundos -= Time.deltaTime;
        }
        else
        {
            segundos = 1.5f;
            swapColor();
        }

	}

    /*
    void swapColor() {  
        private Color bue, red;
        red = new Color(255,115,63);
        blue = new Color
    //rayitos[0].GetComponent<ParticleSystem>().startColor = 
    }
    */
    void swapColor()
    {
        Color blue, red;

        red = new Color(255f/255f,115f/255f, 63f/255f);
        blue = new Color(61f/255f, 149f/255f, 248f/255f);

        if (gameObject.tag == "BlueBattery")
        {
            gameObject.tag = "RedBattery";
        }
        else
        {
            gameObject.tag = "BlueBattery";
        }

       for (int i=0; i<6; i++)
        {
            if (gameObject.tag=="BlueBattery")
            {
                rayitos[i].GetComponent<ParticleSystem>().startColor = blue;
            }
            else
            { 
                rayitos[i].GetComponent<ParticleSystem>().startColor = red;
            }
        }
    }

}