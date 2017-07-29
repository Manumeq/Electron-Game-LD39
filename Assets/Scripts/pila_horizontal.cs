using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pila_horizontal : MonoBehaviour {
    public int speed;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        gameObject.transform.Translate(Vector2.right * speed * Time.deltaTime);
	}
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag == "DestroyPoint")
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "DestroyPoint")
        {
            Destroy(gameObject);
        }
    }
}
