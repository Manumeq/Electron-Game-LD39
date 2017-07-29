using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCircle : MonoBehaviour {
    public bool condition;
    public GameObject Circle;
    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (condition)
        {
            Instantiate(Circle, gameObject.transform.position, gameObject.transform.rotation);
            condition = false;
        }

    }
}
