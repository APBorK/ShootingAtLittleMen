using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Bullet : MonoBehaviour
{
    public float Damage
    {
        get => _damage;
        set => _damage = value;
    }
    
    [SerializeField] private float _minDamage;
    [SerializeField] private float _maxDamage;
    private float _damage;

    private void OnTriggerEnter(Collider oter)
    {
        if (oter.gameObject.CompareTag("Player"))
        {
            _damage = Random.Range(_minDamage,_maxDamage);
            gameObject.SetActive(false);
        }
    }
}
