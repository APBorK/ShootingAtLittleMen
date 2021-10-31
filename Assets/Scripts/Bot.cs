using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bot : MonoBehaviour
{

    [SerializeField] private HealthBar _healthBar;
    [SerializeField] private Bullet _bullet;
    [SerializeField] private int _maxHealth;
    [SerializeField] private Animator _bot;
    [SerializeField] private MovePlayer _movePlayer;
    private bool _kill = false;

    private void Start()
    {
        _healthBar.SetMaxHealth(_maxHealth);
    }

    private void Update()
    {
        if (_healthBar.HealtshSlider.value <= 0)
        {
            _bot.avatar = null;
            _kill = true;
            _movePlayer.NextWayPoint(_kill);
        }
    }

    private void OnTriggerEnter(Collider oter)
    {
        if (oter.gameObject.CompareTag("Bullet"))
        {
            _healthBar.SetHealth(_bullet.Damage);
        }
    }
}
