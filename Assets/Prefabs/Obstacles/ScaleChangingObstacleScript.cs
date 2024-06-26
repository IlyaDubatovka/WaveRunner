using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class ScaleChangingObstacleScript : MonoBehaviour
{
    [SerializeField] private float _minScaleModificator;
    [SerializeField] private float _maxScaleModificator;
    [SerializeField] private float _minSpeedTransformation;
    [SerializeField] private float _maxSpeedTransformation;
    private Transform _transform;
    private float _scaleModificator;
    private float _speedTransformation;

    private void Awake()
    {
        _transform = GetComponent<Transform>();
        _scaleModificator = Random.Range(_minScaleModificator, _maxScaleModificator);
        _speedTransformation = Random.Range(_minSpeedTransformation, _maxSpeedTransformation);
    }

    private void Update()
    {
        var scale = _transform.localScale;
        scale.x = Mathf.PingPong(Time.time * _speedTransformation, _scaleModificator);
        scale.y = Mathf.PingPong(Time.time * _speedTransformation, _scaleModificator);
        _transform.localScale = scale;
    }
}
