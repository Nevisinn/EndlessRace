using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioController : MonoBehaviour
{
    [SerializeField]
    private Sprite audioOn;

    [SerializeField]
    private Sprite audioOff;

    [SerializeField]
    private Image audioBtnImage;

    [SerializeField]
    private Slider slider;

    // [SerializeField]
    // private AudioClip clip;
    // public AudioSource audioSource;

    private void Update()
    {
        AudioListener.volume = slider.value;
    }

    // public void SetAudio()
    // {
    //     if (AudioListener.volume == 1)
    //     {
    //         AudioListener.volume = 0;
    //         audioBtnImage.sprite = audioOff;
    //     }
    //     else
    //     {
    //         AudioListener.volume = 1;
    //         audioBtnImage.sprite = audioOn;
    //     }
    //     // AudioListener.volume = AudioListener.volume == 1 ? 0 : 1;
    //     // audioBtnImage.sprite = AudioListener.volume == 1 ? audioOff : audioOn;
    // }
}
