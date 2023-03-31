using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using Unity.UI;
using UnityEngine.UI;

public class TriggerSound : MonoBehaviour, ISelectHandler , IPointerEnterHandler
{
    [SerializeField] Slider volumeslider;
    void Start()
    {
        if (!PlayerPrefs.HasKey("background"))
        {
            PlayerPrefs.SetFloat("background", 1);
        }
        else
        {
            Load();
        }
        AudioManager.instance.Play("background");
    }

    public void ChangeVolume()
    {
        AudioListener.volume = volumeslider.value;
        Save();
    }

    private void Load()
    {
        volumeslider.value = PlayerPrefs.GetFloat("background");
    }

    private void Save()
    {
        PlayerPrefs.SetFloat("background", volumeslider.value);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        print("entered");
        AudioManager.instance.Play("beep2");
    }

    public void OnSelect( BaseEventData eventData )
    {
        print("selected");
        AudioManager.instance.Play("beep");
    }
}
