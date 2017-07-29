using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Camera.main.gameObject.transform.position.y - gameObject.transform.position.y > 10)
        {
            Destroy(gameObject);
        }
    }
}
