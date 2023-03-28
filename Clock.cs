using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Clock : MonoBehaviour
{
    // Start is called before the first frame update
    public Text clockText;

    private void Awake()
    {
        clockText = GetComponent<Text>();

    }

    // Update is called once per frame
    private void Update()
    {
        DateTime time = DateTime.Now;
        string hour = LeadingZero(time.Hour);
        string minute = LeadingZero(time.Minute);


        clockText.text = hour + ":" + minute;
    }

    string LeadingZero(int n)
    {
        return n.ToString().PadLeft(2, '0');
    }
}
