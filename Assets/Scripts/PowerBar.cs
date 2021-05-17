using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerBar : MonoBehaviour
{
    public Slider slider;
    public void setPower(int val)
    {
        slider.value = val;
    }
    public void setMaxPower(int val)
    {
        slider.maxValue = val;
    }
}
