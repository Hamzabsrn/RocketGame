using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Wall
{
    public class MoverWallController : WallController
    {
        [SerializeField] Vector3 _direction;
        [SerializeField] float _speed = 1f;

        Vector3 _startPosition;
        const float FULL_CIRCLE = Mathf.PI * 2f;
        float _factor;

        private void Awake()
        {
            _startPosition = transform.position;
        }

        private void Update()
        {
            float cycle = Time.time / _speed;
            float sinWave = Mathf.Sin(cycle * FULL_CIRCLE);

            _factor = sinWave / 2f + 0.5f;

            Vector3 offset = _direction * _factor;
            transform.position = offset + _startPosition;
        }
    }
}
