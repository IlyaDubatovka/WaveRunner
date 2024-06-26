
using UnityEngine;


public class RotatingObstacleScript : MonoBehaviour
{
    [SerializeField] private float _minRotationnSpeed;
    [SerializeField] private float _maxRotationSpeed;
    private Transform _transform;
    private float rotationSpeed;

    private void Awake()
    {
        _transform = GetComponent<Transform>();
        rotationSpeed = Random.Range(_minRotationnSpeed,_maxRotationSpeed);
    }

    private void Update()
    {
        var currentRotation = _transform.eulerAngles;
        currentRotation.z = Mathf.PingPong(Time.time * rotationSpeed, 360);
        _transform.eulerAngles = currentRotation;
    }
}
