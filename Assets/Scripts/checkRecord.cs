using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class checkRecord : MonoBehaviour {
    ToolBox toolbox;

	// Use this for initialization
	void Start () {
        toolbox = ToolBox.Instance;
        if (toolbox.record)
        {
            GameObject.Find("recordImage").GetComponent<Image>().enabled = true;
            toolbox.record = false;
        }
    }
	
	// Update is called once per frame
	void Update () {
	}
}
