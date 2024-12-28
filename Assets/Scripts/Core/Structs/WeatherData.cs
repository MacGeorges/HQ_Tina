using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeatherData
{
}
// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);

    [Serializable]
    public struct WeatherDataStruct
    {
        public DateTime approvedTime;
        public DateTime referenceTime;
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
        public DateTime validTime;
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
