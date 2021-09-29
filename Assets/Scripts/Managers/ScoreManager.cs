using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreManager : MonoBehaviour
{
    public static int scoreValue;


    Text text;


    void Awake ()
    {
        text = GetComponent <Text> ();
        scoreValue = 0;
    }


    void Update ()
    {
        text.text = "Score: " + scoreValue;
    }
}
