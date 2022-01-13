using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeControler : MonoBehaviour
{
    public Slider VolumeSlider;
    public GameObject Player;

    private void Update()
    {
       AudioListener.volume = VolumeSlider.value;
    }
}
