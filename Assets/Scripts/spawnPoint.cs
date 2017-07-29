using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnPoint : MonoBehaviour {
    public int creationSpeed;
    private float tiempo;
    public GameObject barraPositiva;
    public GameObject barraNegativa;
	// Use this for initialization
	void Start () {
        tiempo = 0;
	}
	
	// Update is called once per frame
	void Update () {
        tiempo -= creationSpeed * Time.deltaTime;
        if (tiempo < 0)
        {
            tiempo = 5;
            Instantiate(barraPositiva, gameObject.transform.position, gameObject.transform.rotation);
        }
	}


    private void OnCollisionEnter2D(Collision2D collision)
    {
        
    }
}
