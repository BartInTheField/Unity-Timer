using System.Collections;
using System.Collections.Generic;
using BartInTheField.Timer;
using UnityEngine;
using UnityEngine.UI;

public class TimerTester : MonoBehaviour
{
    [SerializeField] private Timer timer = default;

    [SerializeField] private Text counterText = default;

    private void Start()
    {
        timer.OnTimeout += ReactToTimeout;
        timer.OnTimeChanged += SetCounterText;
    }

    private void OnDestroy()
    {
        timer.OnTimeout -= ReactToTimeout;
        timer.OnTimeChanged -= SetCounterText;
    }

    private void ReactToTimeout()
    {
        print("Timeout");
    }

    private void SetCounterText(float counter)
    {
        counterText.text = Mathf.Ceil(counter) + "";
    }
}
