using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrontendScript : MonoBehaviour
{

    //public GameObject uiPrefab;
    public static int lives=10;
    public static string score;
    public static string highScore;


    void Awake()
    {
        //DontDestroyOnLoad(this.gameObject);
    }

    void Start()
    {
        //print(SharedData.GetScore());

        print("frontend object");
        print("lives=" + lives);
        lives++;
    }

    public void StartUI()
    {
        //Instantiate(uiPrefab, new Vector2(0,0), Quaternion.identity);
    }





}
