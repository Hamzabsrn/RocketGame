using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PlayerFuel
{
    public class Fuel : MonoBehaviour
    {
        [SerializeField] float _maxFuel = 100f;
        [SerializeField] float _currentFuel;

        public bool IsEmpty => _currentFuel < 1f;
        public float CurrentFuel => _currentFuel / _maxFuel;

        private void Awake()
        {
            _currentFuel = _maxFuel;
        }

        public void FuelIncrease(float increase)
        {
            _currentFuel += increase;
            _currentFuel = Mathf.Min(_currentFuel, _maxFuel);

            SoundManager.Instance.StopSound(0);
        }

        public void FuelDecrease(float decrease)
        {
            _currentFuel -= decrease;
            _currentFuel = Mathf.Max(_currentFuel, 0f);

            SoundManager.Instance.PlaySound(0);
        }
    }

}
