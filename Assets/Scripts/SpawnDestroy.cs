using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnDestroy : MonoBehaviour {
    public bool condition;
    public GameObject DestroyPoint;
    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (condition)
        {
            Instantiate(DestroyPoint, gameObject.transform.position, gameObject.transform.rotation);
            condition = false;
        }
        
    }
}
