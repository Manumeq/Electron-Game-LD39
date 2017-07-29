using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnSpawn : MonoBehaviour {
    private bool mov;
    public GameObject spawnPoint;
	// Use this for initialization
	void Start () {
        mov = true;
	}
	
	// Update is called once per frame
	void Update () {
        if (mov)
        {
            Instantiate(spawnPoint, gameObject.transform.position, gameObject.transform.rotation);
            mov = false;
        }
        if (gameObject.transform.position.y % 10 == 0)
        {
            mov = true;
        }
	}
}
