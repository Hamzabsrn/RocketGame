using DefaultAction;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float _force;
    private Rigidbody _rigidbody;
    DefaultInput _input;

    bool _isForceUp;


    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _input = new DefaultInput();
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
            _rigidbody.AddForce(Vector3.up * _force * Time.deltaTime);
        }



    }
}
