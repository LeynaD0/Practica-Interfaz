using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fuerza : MonoBehaviour
{
    [SerializeField]
    Vector3 fuerza;

    Rigidbody body;

    void Start()
    {
        body = GetComponent<Rigidbody>();
    }

    public void AddForce()
    {
        body.AddForce(fuerza, ForceMode.Impulse);
    } 

    public void AddForce(Vector3 parametro)
    {
        body.AddForce(parametro, ForceMode.Impulse);
    }
}
