using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeController : MonoBehaviour
{
    public float MoveSpeed = 5;
    public float SteerSpeed = 180;
    void Start()
    {
        
    }

    void Update()
    {
        transform.position += transform.forward * MoveSpeed * Time.deltaTime;   

        float steerDirection = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up * steerDirection * SteerSpeed * Time.deltaTime);
    }
}
