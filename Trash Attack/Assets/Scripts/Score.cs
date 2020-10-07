using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Score : MonoBehaviour {

    public static int scoreValue = 0;
    private Text score;

    public void Start()
    {
        score = GetComponent<Text> ();
    }

    public void Update()
    {
        score.text = "Score: " + scoreValue;
    }

}
