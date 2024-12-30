using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PanelWeather : PanelController
{

    private UnityEvent<string> callback = new UnityEvent<string>();

    [SerializeField]
    private WeatherDataStruct weatherDataStruct;

    public System.DateTime validTime;

    [Header("UI Elements")]
    [SerializeField]
    private Transform weatherForecastRoot;
    [SerializeField]
    private WeatherForecastUIElement weatherForecastPrefab;

    private void Start()
    {
        callback.AddListener(RequestCallback);
    }

    private void OnEnable()
    {
        // 59.70194185408485, 15.092265176259733
        // https://opendata-download-metfcst.smhi.se/api/category/pmp3g/version/2/geotype/point/lon/15.0922/lat/59.7019/data.json
        NetworkManager.Instance.GetDirectRequest("https://opendata-download-metfcst.smhi.se/api/category/pmp3g/version/2/geotype/point/lon/15.0922/lat/59.7019/data.json", callback);
    }

    private void RequestCallback(string response)
    {
        Debug.Log("Weather answer : " + response);
        weatherDataStruct = JsonUtility.FromJson<WeatherDataStruct>(response);

        foreach(Transform child in weatherForecastRoot)
        {
            Destroy(child.gameObject);
        }

        foreach(TimeSeries timeData in weatherDataStruct.timeSeries)
        {
            WeatherForecastUIElement weatherForecastElement = Instantiate(weatherForecastPrefab, weatherForecastRoot);
            weatherForecastElement.Initialize(timeData.validTime, timeData.parameters.Find(p => p.name == "t").values[0].ToString() + "°C", timeData.parameters.Find(p => p.name == "msl").values[0].ToString() + " hPa");
            //weatherForecastElement.Initialize(timeData.validTime, timeData.parameters.t + "°C", timeData.parameters.msl + " hPa");
        }
    }
}
