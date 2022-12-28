using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed = 10.0f;
    public float distance = 5.0f;
    private float startPosition;

    void Start()
    {
        startPosition = transform.position.x;
    }

    void Update()
    {
        float newPosition = Mathf.Sin(Time.time * speed) * distance + startPosition;
        transform.position = new Vector3(newPosition, transform.position.y, transform.position.z);
    }
}
