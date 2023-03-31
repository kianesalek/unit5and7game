using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class FirstButton : MonoBehaviour
{
    // add this script to the first button you want to be automatically selected 

    
        
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Button>().Select();
        
        
    }

   


}
