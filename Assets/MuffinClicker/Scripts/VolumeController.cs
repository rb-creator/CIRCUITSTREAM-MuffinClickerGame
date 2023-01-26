using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeController : MonoBehaviour
{
   //[SerializeField]
   public Slider _volumeSlider;

   public void OnVolumeChanged()
    {
        Debug.Log("Volume Slider has been changed");
        AudioListener.volume = _volumeSlider.value;
    }

}
