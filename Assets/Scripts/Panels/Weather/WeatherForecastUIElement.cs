using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class WeatherForecastUIElement : MonoBehaviour
{
    [SerializeField]
    private TMP_Text dateTime;
    [SerializeField]
    private TMP_Text temperature;
    [SerializeField]
    private TMP_Text pressure;

    public void Initialize( string newDateTime, string newTemperature, string newPressure)
    {
        dateTime.text = newDateTime;
        temperature.text = newTemperature;
        pressure.text = newPressure;
    }
}
