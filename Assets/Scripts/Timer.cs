using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Diagnostics;
using System.Threading;
using System;

public class Timer : MonoBehaviour
{
    public Text TimerText;
    float NotStopwatch;
    public Text elapsed;
    // private Stopwatch stopWatch = new Stopwatch();
    // Start is called before the first frame update
    public void Start()
    {
        NotStopwatch = 0;
    }

    // Update is called once per frame
    void Update()
    {
        NotStopwatch = NotStopwatch + Time.deltaTime; 
        TimeSpan time = TimeSpan.FromSeconds(NotStopwatch);
        TimerText.text = time.ToString(@"m\:ss\:ff");
        // TimerText.text = stopWatch.Elapsed.Minutes.ToString("00") + ":" + stopWatch.Elapsed.Seconds.ToString("00") + "." + ((stopWatch.Elapsed.Milliseconds / 10).ToString("D"));
    }

    public void Win()
    {
        elapsed.text = TimerText.text;
        // grab the text
        // set 
    }
}
