using System;
using System.Collections.Generic;

public class Feature
{
    public string Name { get; set; }
    public Dictionary<string, string> Properties { get; set; }

    public Feature(string name)
    {
        Name = name;
        Properties = new Dictionary<string, string>();
    }

    public void AddProperty(string key, string value)
    {
        Properties[key] = value;
    }

    public override string ToString()
    {
        return $"{Name}: {string.Join(", ", Properties)}";
    }
}

public class FeatureCollection
{
    private List<Feature> features;

    public FeatureCollection()
    {
        features = new List<Feature>();
    }

    public void AddFeature(Feature feature)
    {
        features.Add(feature);
    }

    public void RemoveFeature(string name)
    {
        features.RemoveAll(f => f.Name == name);
    }

    public Feature GetFeature(string name)
    {
        return features.Find(f => f.Name == name);
    }

    public void ListFeatures()
    {
        foreach (var feature in features)
        {
            Console.WriteLine(feature);
        }
    }
}