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
    [SerializeField] public Scrollbar Scrollbar;

    public StatusBar(string name, int maxValue = 100, int currentValue = 100)
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
        UpdateStatusBar();
    }

    public void UpdateStatusBar()
    {
        if (CurrentValue != NewValue) // Only redraw the screen if something has changed
        {
            CurrentValue = NewValue;
            DisplayText.text = $"{CurrentValue}/{MaxValue}";
            Scrollbar.size = ((float)CurrentValue / 100); // Scrollbar size is 0 - 1
        }
    }
}
