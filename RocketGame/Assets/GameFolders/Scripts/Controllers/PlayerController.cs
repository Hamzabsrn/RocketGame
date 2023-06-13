using DefaultAction;
using System.Collections;
using System.Collections.Generic;
using PlayerMover;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    DefaultInput _input;

    Mover _mover;

    bool _isForceUp;


    private void Awake()
    {
        _input = new DefaultInput();
        _mover = new Mover(rigidbody: GetComponent<Rigidbody>());
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
    }
    private void FixedUpdate()
    {
        if (_isForceUp)
        {
            _mover.FixedTick();
        }
    }
}
