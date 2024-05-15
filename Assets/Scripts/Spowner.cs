using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Spowner : MonoBehaviour
{
    [SerializeField] private List<Wave> _waves;
    [SerializeField] private Transform _spawnPoint;
    [SerializeField] private Player _player;

    private Wave _currentWave;
    private int _currentWaveNumber = 0;
    private float _timeAfterLastSpown;
    private int _spawned;

    private void Start()
    {
        SetWave(_currentWaveNumber);
    }

    private void Update()
    {
        if(_currentWave == null)
            return;
        _timeAfterLastSpown = Time.deltaTime;

        if(_timeAfterLastSpown >= _currentWave.Delaly)
        {

        }
    }

    private void SetWave(int index)
    {
        _currentWave = _waves[index];
    }
}

[System.Serializable]
public class Wave
{
    public GameObject Template;
    public float Delaly;
    public int Count;
}
