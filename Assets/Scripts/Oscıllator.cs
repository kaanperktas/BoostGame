using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscıllator : MonoBehaviour
{
    Vector3 startingPosition;
    [SerializeField] private Vector3 movementVector;
    [SerializeField] private float period = 2f;

    public float movementFactor;

    void Start()
    {
        startingPosition = transform.position;
        
    }

    void Update()
    {   if (period <= Mathf.Epsilon) { return; }
        float cycles = Time.time / period;
        const float tau = Mathf.PI * 2;
        float rawSinWave = Mathf.Sin(cycles * tau);

        movementFactor = (rawSinWave + 1f) / 2f;


        Vector3 offset = movementVector * movementFactor;
        transform.position = offset + startingPosition;
    }
}
