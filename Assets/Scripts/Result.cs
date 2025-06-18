using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Result : MonoBehaviour
{
    public TMP_Text resultText;
    void Start()
    {
        resultText.text = "Score: "+PlayerPrefs.GetInt("Score");
    }

   
}
