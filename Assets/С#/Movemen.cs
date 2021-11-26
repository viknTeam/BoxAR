using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movemen : MonoBehaviour
{
    [SerializeField] private float Speed;
    private float HrSpeed;
    Rigidbody rb;


    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        transform.Translate(HrSpeed, 0, 0);
    }

}