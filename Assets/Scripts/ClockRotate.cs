using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockRotate : MonoBehaviour
{
    const float hoursToDegrees = -3000f;
    const float minutesToDegrees = -600f;
    const float secondsToDegrees = -600f;
    

    // Expose Field to Unity Editor 
    // Public is exposed by default
    // Not good to make public if you dont want other classes to be able to modify it
    [SerializeField]
    Transform hoursPivot;

    [SerializeField]
    Transform minutesPivot;

    [SerializeField]
    Transform secondsPivot;
    void Update () {
        TimeSpan time = DateTime.Now.TimeOfDay;
        hoursPivot.localRotation = Quaternion.Euler(0f, 0f, hoursToDegrees * (float) time.TotalHours);
        minutesPivot.localRotation = Quaternion.Euler(0f, 0f, minutesToDegrees * (float)time.TotalMinutes);
        secondsPivot.localRotation = Quaternion.Euler(0f, 0f, secondsToDegrees * (float)time.TotalSeconds);
    }

}
