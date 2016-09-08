using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class Intensity : MonoBehaviour
{
    public GameObject Speaker1;
    public GameObject Speaker2;
    public int Speaker1_Amplitude = 1;
    public int Speaker2_Amplitude = 1;
    public GameObject Player;
    private int speakerWatt = 100;
    private double speakerIntensity1;
    private double speakerIntensity2;
    private double distance1;
    private double distance2;
    private double intensity = 1.24;
    public int f = 360;//Frequency Calculated
    public int c = 320; //Speed of Sound
    private double lambda;
    public Text myText;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        lambda = c / f;
        distance1 = Vector3.Distance(Speaker1.transform.position, Player.transform.position);
        distance2 = Vector3.Distance(Speaker2.transform.position, Player.transform.position);
        speakerIntensity1 = speakerWatt / (4 * Math.PI * distance1 * distance1);
        speakerIntensity2 = speakerWatt / (4 * Math.PI * distance2 * distance2);
        intensity = speakerIntensity1 + speakerIntensity2;
        //myText.text = "Intensity of " + f + "Hz " + ": " + intensity + " W/m²";
        myText.text = "Total Intensity"+ ": " + intensity + " W/m²";//To do, intensity should face destructive interference based on Frequency
    }
}
