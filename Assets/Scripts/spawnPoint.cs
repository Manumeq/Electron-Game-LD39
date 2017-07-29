using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnPoint : MonoBehaviour {
    public int creationSpeed;
    private float tiempo;
    public GameObject[] barrasPositivas;
    public GameObject barraNegativa;
    private int selectorPila;
	// Use this for initialization
	void Start () {
        tiempo = 0;
	}
	
	// Update is called once per frame
	void Update () {
        if (Camera.main.gameObject.transform.position.y - gameObject.transform.position.y > 10)
        {
            Destroy(gameObject);
        }
        tiempo -= creationSpeed * Time.deltaTime;
        if (tiempo < 0)
        {
            tiempo = 5;
            selectorPila = UnityEngine.Random.Range(0, barrasPositivas.Length);
            Instantiate(barrasPositivas[selectorPila], gameObject.transform.position, gameObject.transform.rotation);
        }
	}


    private void OnCollisionEnter2D(Collision2D collision)
    {
        
    }
}
