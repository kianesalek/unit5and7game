using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class ScoreScript : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        string score = SharedData.GetScoreText();
        SetScoreText( score );
    }

    public void SetScoreText( string txt )
    {
        Text scoreText = GetComponent<Text>();
        scoreText.text="Score: " + txt;

    }
}
