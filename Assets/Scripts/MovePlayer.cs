using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MovePlayer : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private List<Transform> _wayPoint;
    [SerializeField] private Animator _animator;
    [SerializeField] private int _valueBot;
    private NavMeshAgent _myAgents;
    private int _valueWayPoint;
    private int _kill;


    void Start()
    {
        _myAgents = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        if (Input.GetMouseButton(1))
        {
            GoToTheWayPoint();
        }

        if (_wayPoint[_valueWayPoint].position.x == transform.position.x)
        {
            _animator.SetBool("Walck",false);
            _animator.SetBool("Shoot",true);
        }

    }

    void GoToTheWayPoint()
    {
        _myAgents.SetDestination(_wayPoint[_valueWayPoint].position);
        _myAgents.speed = _speed;
        _animator.SetBool("Walck",true);
    }

    public void NextWayPoint(bool kill)
    {
        if (kill)
        {
            _kill++;
        }
        if (_kill == _valueBot)
        {
            _valueWayPoint++;
        }
    }

}
