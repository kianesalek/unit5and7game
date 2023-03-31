using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using Unity.UI;
using UnityEngine.UI;

public class TriggerSound2 : MonoBehaviour
{
    [SerializeField] Slider volumeslider1;
    void Start()
    {
        if (!PlayerPrefs.HasKey("beep"))
        {
            PlayerPrefs.SetFloat("beep", 1);
        }
        else
        {
            Load();
        }
        AudioManager.instance.Play("beep");
    }

    public void ChangeVolume1()
    {
        AudioListener.volume = volumeslider1.value;
        Save();
    }

    private void Load()
    {
        volumeslider1.value = PlayerPrefs.GetFloat("beep");
    }

    private void Save()
    {
        PlayerPrefs.SetFloat("beep", volumeslider1.value);
    }

}