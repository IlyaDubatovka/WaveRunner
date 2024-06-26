using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorizontalMovingObstacle : MonoBehaviour
{
    [SerializeField] private float _speed;
    private float _amplitude ;

    private Transform _transform;

    // Start is called before the first frame update
    void Awake()
    {
        _transform = GetComponent<Transform>();

        _amplitude = Random.Range(2, 15);

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = _transform.position;
        newPosition.x=Mathf.PingPong(Time.time * _speed, _amplitude);
        _transform.position = newPosition;
    }
}
