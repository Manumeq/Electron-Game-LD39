using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnSpawn : MonoBehaviour {
    public bool condition;
    public GameObject spawnPoint;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        if (condition)
        {
            Instantiate(spawnPoint, gameObject.transform.position, gameObject.transform.rotation);
            condition = false;
        }
            
	}
}
