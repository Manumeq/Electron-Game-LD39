using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnRombo : MonoBehaviour {
    public bool condition;
    public GameObject Rombo;
    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (condition)
        {
            Instantiate(Rombo, gameObject.transform.position, gameObject.transform.rotation);
            condition = false;
        }

    }
}
