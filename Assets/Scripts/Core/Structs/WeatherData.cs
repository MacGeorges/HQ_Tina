using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeatherData{}

// More info on Weather data and parameters:
// https://opendata.smhi.se/apidocs/metfcst/parameters.html

[Serializable]
public struct WeatherDataStruct
{
    //public DateTime approvedTime;
    public string approvedTime;
    //public DateTime referenceTime;
    public string referenceTime;
    public Geometry geometry;
    public List<TimeSeries> timeSeries;
}

[Serializable]
public struct Geometry
{
    public string type;
    public List<List<double>> coordinates;
}


[Serializable]
public struct TimeSeries
{
    //public DateTime validTime;
    public string validTime;
    public List<Parameter> parameters;
}


[Serializable]
public struct Parameter
{
    public string name;
    public string levelType;
    public int level;
    public string unit;
    public List<double> values;
}

[Serializable]
public struct Parameters
{
    public float msl; //Air pressure
    public float t; //Air temperature
    public float vis; //Horizontal visibility
    public int wd; //Wind direction 	Integer
    public float ws; //Wind speed
    public int r; //Relative humidity
    public int tstm; //Thunder probability
    public int tcc_mean; //Mean value of total cloud cover
    public int lcc_mean; //Mean value of low level cloud cover
    public int mcc_mean; //Mean value of medium level cloud cover
    public int hcc_mean; //Mean value of high level cloud cover
    public float gust; //Wind gust speed
    public float pmin; //Minimum precipitation intensity
    public float pmax; //Maximum precipitation intensity
    public int spp; //Percent of precipitation in frozen form
    public int pcat; //Precipitation category
    public float pmean; //Mean precipitation intensity
    public float pmedian; //Median precipitation intensity
    public int wsymb2; //Weather symbol
}
