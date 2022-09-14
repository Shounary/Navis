using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeSliderChange : MonoBehaviour
{
    public Slider volumeSlider;

    private AudioSource source;

    void Start()
    {
        source = GetComponent<AudioSource>();
        volumeSlider.value = source.volume;
        volumeSlider.onValueChanged.AddListener(UpdateVolume);
    }

    void UpdateVolume(float val)
    {
        source.volume = val;
    }
}
