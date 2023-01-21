using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DisplayerTime : MonoBehaviour
{
    [SerializeField] private Stopwatch _stopwatch;
    [SerializeField] private Text _text;
    private readonly int _numberOfSimbolsAfterComma = 3;
    private void Update()
    {
        DisplayText();
    }
    private void DisplayText()
    {
        _text.text = $"{Math.Round(_stopwatch.CurrentTime,_numberOfSimbolsAfterComma)}";
    }
}
