
using UnityEngine;
using Random = UnityEngine.Random;

public class VerticalMovingObstacleScript : MonoBehaviour
{
    [SerializeField] private float _maxAmplitude=1f;
    [SerializeField] private float _minAmplitude=2f;
    [SerializeField] private float _maxSpeed=1f;
    [SerializeField] private float _minSpeed=2f;
    private Transform _transform;
    private float _amplitude;
    private float _speed;
    private float _startPositionY;

    private void Awake()
    {
        _transform = GetComponent<Transform>();
        _amplitude = Random.Range(_minAmplitude, _maxAmplitude);
        _speed = Random.Range(_minSpeed, _maxSpeed);
        _startPositionY = _transform.position.y;
    }

    private void Update()
    {
        Vector3 newPosition = _transform.position;
        newPosition.y =_startPositionY+ Mathf.PingPong(Time.time * _speed, _amplitude);
        _transform.position = newPosition;
    }
}

