using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class HealthBar : MonoBehaviour
{
    public Slider slider;
    public TMP_Text hitPoints;

    public void SetMaxHealth(int health)
    {
        slider.maxValue = health;
        slider.value = health;
        hitPoints.text = health.ToString();
    }
    
    public void SetHealth(int health)
    {
        slider.value = health;
        hitPoints.text = health.ToString();
    }
}