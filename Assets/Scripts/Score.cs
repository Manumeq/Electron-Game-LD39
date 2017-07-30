using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour {
    public int score;
	// Use this for initialization
	void Start () {
        DontDestroyOnLoad(gameObject);
        
    }
	
	// Update is called once per frame
	void Update () {
        Debug.Log(score);
	}
    public void algo()
    {

    }
    
}
