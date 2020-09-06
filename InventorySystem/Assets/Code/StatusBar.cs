using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class StatusBar : MonoBehaviour
{
    //private string _name;
    //private int _maxValue;
    //private int _currentValue;
    //private int _newValue;

    public int NewValue;

    [SerializeField] public string Name;
    [SerializeField] public int MaxValue;
    [SerializeField] public int CurrentValue;
    [SerializeField] public TextMeshProUGUI DisplayText;

    StatusBar(string name, int maxValue = 100, int currentValue = 100)
    {
        Name = name;
        MaxValue = maxValue;
        CurrentValue = currentValue;
    }

    void Start()
    {

    }

    void Update()
    {
        UpdateValueText();
    }

    public void UpdateValueText()
    {
        if (CurrentValue != NewValue)
        {
            CurrentValue = NewValue;
            DisplayText.text = $"{CurrentValue}/{MaxValue}";
        }
    }
}
