using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgressBar : Bar
{
    [SerializeField] private Spawner _spowner;

    private void OnEnable()
    {
        _spowner.EnemyCountChanged += OnValueChanged;
        Slider.value = 0;
    }

    private void OnDisable()
    {
        _spowner.EnemyCountChanged -= OnValueChanged;
    }
}
