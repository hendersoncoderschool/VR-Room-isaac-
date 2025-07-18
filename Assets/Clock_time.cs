using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Globalization;

public class ClockTime : MonoBehaviour
{
    GameObject hourHand;
    GameObject minuteHand;
    GameObject secondHand;
    // Start is called before the first frame update
    void Start()
    {
        hourHand = transform.Find("Clock_Analog_A_Hour").gameObject;
        minuteHand = transform.Find("Clock_Analog_A_Minute").gameObject;
        secondHand = transform.Find("Clock_Analog_A_Second").gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        DateTime moment = DateTime.Now;

        hourHand.transform.rotation = Quaternion.Euler((moment.Hour*30f)+90f, 0f, -90f);
        minuteHand.transform.rotation = Quaternion.Euler((moment.Minute*6f)+90f,0f,-90f);
        secondHand.transform.rotation = Quaternion.Euler((moment.Second*6f)+90f,0f,-90f);
    }
}
