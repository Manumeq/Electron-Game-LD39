using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dumper : MonoBehaviour {
    public float secs;
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        secs = secs - (1 * Time.deltaTime);
        if (secs < 0) { 
            Destroy(gameObject);
        }
    }
    private void OnDestroy()
    {
        ToolBox toolbox = ToolBox.Instance;
        toolbox.volverAtras();
    }
}