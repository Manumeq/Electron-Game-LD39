using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnMolino : MonoBehaviour {
    public bool condition;
    public GameObject Molino;
    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (condition)
        {
            Debug.Log(gameObject.transform.position.y);
            Instantiate(Molino, gameObject.transform.position, gameObject.transform.rotation);
            condition = false;
        }

    }
}
