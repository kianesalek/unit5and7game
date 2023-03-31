using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class CanvasScript : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject score;

    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);


    }
    void Start()
    {
        

        
    }

    void OnEnable()
    {
        print("*** scene start ***");
    }

    // Update is called once per frame
    void Update()
    {

        Scene scene =  SceneManager.GetActiveScene();
        //print("scene=" + scene.name);
        if( (scene.name == "level1") || (scene.name == "level2"))
        {
            score.SetActive(true);
        }
        else
        {
            score.SetActive(false);
        }

        
    }
}
