using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class SFXVolume : MonoBehaviour, ISelectHandler

{
    [SerializeField] Slider volumeslider1;

    // Start is called before the first frame update
    void Start()
    {
        if (!PlayerPrefs.HasKey("musicVolume"))
        {
            PlayerPrefs.SetFloat("musicVolume", 1);
        }
        else
        {
            Load();
        }
    }

    public void ChangeVolume2()
    {
        AudioListener.volume = volumeslider1.value;
        Save();
    }

    private void Load()
    {
        volumeslider1.value = PlayerPrefs.GetFloat("musicVolume");
    }

    private void Save()
    {
        PlayerPrefs.SetFloat("musicVolume", volumeslider1.value);
    }
    public void OnSelect(BaseEventData eventData)
    {
        //print("selected");
        AudioManager.instance.Play("beep");
    }
}