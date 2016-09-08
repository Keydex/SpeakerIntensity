using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class ObjDist : MonoBehaviour
{
    public GameObject Speaker;
    public GameObject Player;
    public int objnum;
    public int speakerWatt;
    public double speakerIntensity;
    public double speakerDB;
    private double distanceCalc;
    public double distance;
    public Text myText;
    private double intensityConstant;
    // Use this for initialization
    void Start()
    {
        intensityConstant = Math.Pow(10, -12);
    }

    // Update is called once per frame
    void Update()
    {
        distanceCalc = Vector3.Distance(Speaker.transform.position, Player.transform.position);
        distance = Math.Round(distanceCalc, 1);
        speakerIntensity = speakerWatt / (4 * Math.PI * distance * distance);
        speakerDB = 10 * Math.Log10(speakerIntensity / intensityConstant);
        myText.text = "Distance From Speaker " + objnum + ": " + distance + " m " + Math.Round(speakerDB,1) + " dB";
    }
}
