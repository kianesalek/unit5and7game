using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.Audio;


// to do - watch this brackey's tutorial and implement the audio manager
//https://www.youtube.com/watch?v=6OT43pvUyfY


public class Buttonscript : MonoBehaviour
{
    public AudioClip myAudioClip1;
    public AudioClip myAudioClip2;
    public AudioSource audioSource;



    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("start");
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadScene(string level)
    { 
         SceneManager.LoadScene(level);
    }

    public void IncreaseScore()
    {
        int score = SharedData.GetScore();
        score = score + 10;
        SharedData.SetScore( score );

    }

    public void DecreaseScore()
    {
        int score = SharedData.GetScore();
        score = score - 10;
        SharedData.SetScore( score );

    }

    public void PlayTestButtonSound()
    {
        //myAudioSource.Play();
        //audioSource.PlayOneShot(myAudioClip1, 0.9f);
        AudioManager.instance.Play("beep1");

    }


    public void EnableMenu()
    {
        gameObject.SetActive(true);

    }

    public void DisableMenu()
    {
        gameObject.SetActive(false);

    }

    public void SetSlider( float value )
    {
        Debug.Log( value );
    }

    public void TestButtonScript( string myMessage )
    {
        
        Debug.Log( myMessage );
    }

    
    

}
