using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnSpawn : MonoBehaviour {
    private bool mov;
	// Use this for initialization
	void Start () {
        mov = true;
	}
	
	// Update is called once per frame
	void Update () {
        if (gameObject.transform.position.y % 10 == 0)
        {

        }
	}
}
