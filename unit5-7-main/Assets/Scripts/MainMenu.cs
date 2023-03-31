using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public Slider musicSlider;

    void Start()
    {
        print("main menu start");
        musicSlider.value = 0.5f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
