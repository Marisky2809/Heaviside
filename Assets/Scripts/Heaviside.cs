using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heaviside : MonoBehaviour
{
    private float position = 0f;
    public float velocity = 0f;

    private float startTime;

    public float ac1 = 0f;
    public float ac1T = 0f;

    public float ac2 = 0f;
    public float ac2T = 0f;

    public float consT = 0f;

    void Awake()
    {
        startTime = Time.time;
        position = transform.position.x;
    }

    void Update()
    {
        float time = Time.time - startTime;

        float acceleration = CalculateAcceleration(time);

        float deltaTime = Time.deltaTime;
        velocity += acceleration * deltaTime;

        position += velocity * deltaTime;

        //Debug.Log(velocity);

        transform.position = new Vector3(position, transform.position.y, transform.position.z);
    }

    private float FunctionHeaviside(float time)
    {
        return time >= 0f ? 1f : 0f;
    }
    private float CalculateAcceleration(float time)
    {
        float acceleration = ac1 * (FunctionHeaviside(time) - FunctionHeaviside(time - ac1T)) - ac2 * (FunctionHeaviside(time - consT) - FunctionHeaviside(time - ac2T));
        //Debug.Log(acceleration);
        return acceleration;
    }
}
