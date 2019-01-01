using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalScoreScript : MonoBehaviour
{
    public static int deathValue = 0;
    public Text deaths;


    void Start() //finds the text object
    {
        deaths = FindObjectOfType<Text>();
    }
    private static DeathCounter instance = null;
    public static DeathCounter Instance
    {
        get { return instance; }
    }

    void Update()
    {
        deaths.text = "Your final amount of deaths: " + PlayerPrefs.GetInt("Deaths");   // Tells the player how many times they died in order to complete the game.


    }


}