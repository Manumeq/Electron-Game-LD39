using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderSonidoSonido : MonoBehaviour {
    ToolBox toolbox;
    // Use this for initialization
    void Start()
    {
        toolbox = ToolBox.Instance;
    }

    // Update is called once per frame
    void Update()
    {
        toolbox.sonido = gameObject.GetComponent<Slider>().value;
    }
}
