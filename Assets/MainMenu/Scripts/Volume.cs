using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Volume : MonoBehaviour
{
    public Slider mainSlider;
    float value;

    // I would set this function to the onValueChanged event of the slider.
    public void updateValue()
    {
        Debug.Log(mainSlider.value);
        value = mainSlider.value;
    }
}
