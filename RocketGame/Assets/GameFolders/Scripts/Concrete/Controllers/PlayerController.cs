using DefaultAction;
using System.Collections;
using System.Collections.Generic;
using PlayerMover;
using RotaterMove;
using UnityEngine;
using PlayerFuel;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float _turnSpeed = 10f;
    [SerializeField] float _force = 55f;
    [SerializeField] bool _canMove;

    DefaultInput _input;
    Mover _mover;
    Rotater _rotater;
    Fuel _fuel;

    bool _canForceUp;
    float _leftRight;
    public bool CanMove => _canMove; 
    public float TurnSpeed => _turnSpeed;
    public float Force => _force;

    private void Awake()
    {
        _input = new DefaultInput();
        _mover = new Mover(playerController: this);
        _rotater = new Rotater(playerController: this);
        _fuel = GetComponent<Fuel>();
    }
    private void Start()
    {
        _canMove = true;
    }
    private void OnEnable()
    {
        GameManager.Instance.OnGameOver += HandleOnEventTriggered;
        GameManager.Instance.OnMissionSucced += HandleOnEventTriggered;
    }
    private void OnDisable()
    {
        GameManager.Instance.OnGameOver -= HandleOnEventTriggered;
        GameManager.Instance.OnMissionSucced -= HandleOnEventTriggered;
    }
    private void Update()
    {
        if (!_canMove)
        { return; }
        if (_input.isForceUp && !_fuel.IsEmpty)
        {
            _canForceUp = true;
        }
        else
        {
            _canForceUp = false;
            _fuel.FuelIncrease(0.001f);
        }
        _leftRight = _input.Leftright;
    }
    private void FixedUpdate()
    {
        if (_canForceUp)
        {
            _mover.FixedTick();
            _fuel.FuelDecrease(0.2f);
        }
        _rotater.FixedTick(_leftRight);

    }
    private void HandleOnEventTriggered()
    {
        _canMove = false;
        _canForceUp = false;
        _leftRight = 0f;
        _fuel.FuelIncrease(0f);
    }
}
