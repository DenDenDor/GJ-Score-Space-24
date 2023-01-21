using System.Collections;
using System;
using UnityEngine;
public class Stopwatch : MonoBehaviour
{
    private bool _isTimeLowerAverage = true;
    private float _currentTime = 0;
    private float _averageTime = 50;

    public float CurrentTime { get => _currentTime; set => _currentTime = value; }

    public event Action OnTimeOverAverage;
    private void Update()
    {
        _currentTime += Time.deltaTime;
        if (_isTimeLowerAverage && _currentTime >= _averageTime)
        {
            OnTimeOverAverage?.Invoke();
            _isTimeLowerAverage = false;
        }
    }
    public void ResetTimer()
    {
        _isTimeLowerAverage = true;
        _currentTime = 0;
    }
}
