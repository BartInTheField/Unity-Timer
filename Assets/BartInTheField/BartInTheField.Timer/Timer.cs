using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BartInTheField.Timer
{
    public class Timer : MonoBehaviour
    {
        public event Action OnTimeout = delegate { };
        public event Action<float> OnTimeChanged = delegate { };

        [SerializeField] private float startTime = 1f;
        [SerializeField] private bool loop = false;
        [SerializeField] private bool autoStart = true;

        private bool timeout = true;
        private float timer = 0.0f;

        private void Start()
        {
            if (autoStart)
            {
                StartTimer();
            }
        }

        private void Update()
        {
            if (timer > 0 && !timeout)
            {
                timer -= Time.deltaTime;
                OnTimeChanged.Invoke(timer);
            }
            else if (timer < 0 && !timeout)
            {
                timeout = true;
                OnTimeout.Invoke();

                if (loop)
                {
                    StartTimer();
                }
            }
        }

        public void StartTimer()
        {
            timer = startTime;
            timeout = false;
        }
    }
}
