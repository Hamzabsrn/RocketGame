using DefaultAction;
using System.Collections;
using System.Collections.Generic;
using PlayerMover;
using RotaterMove;
using UnityEngine;


public class PlayerController : MonoBehaviour
{
    [SerializeField] float _turnSpeed = 10f;
    [SerializeField] float _force = 55f;

    DefaultInput _input;

    Mover _mover;
    Rotater _rotater;

    bool _isForceUp;
    float _leftRight;

    public float TurnSpeed => _turnSpeed;
    public float Force => _force;

    private void Awake()
    {
        _input = new DefaultInput();
        _mover = new Mover(playerController: this);
        _rotater = new Rotater(playerController: this);
    }
    private void Update()
    {

        if (_input.isForceUp)
        {
            _isForceUp = true;
        }
        else
        {
            _isForceUp = false;
        }
        _leftRight = _input.Leftright;
    }
    private void FixedUpdate()
    {
        if (_isForceUp)
        {
            _mover.FixedTick();
        }
        _rotater.FixedTick(_leftRight);

    }
}
