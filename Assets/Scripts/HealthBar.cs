using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider HealtshSlider
    {
        get => _healtshSlider;
        set => _healtshSlider = value;
    }
    [SerializeField] private Slider _healtshSlider;
    [SerializeField] private GameObject _gameObject;
    [SerializeField] private float _offset;

    private void Start()
    {
        transform.position = new Vector3(_gameObject.transform.position.x,_gameObject.transform.position.y + _offset, _gameObject.transform.position.z);
        transform.rotation = _gameObject.transform.rotation;
    }

    public void SetMaxHealth(int health)
    {
        _healtshSlider.maxValue = health;
        _healtshSlider.value = health;
    }
    
    public void SetHealth(float health)
    {
        _healtshSlider.value -= health;
    }
}
