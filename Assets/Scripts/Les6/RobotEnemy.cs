using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotEnemy : MonoBehaviour, IEnemy
{
    Rigidbody rb;
    private float _dist = 0;
    private int _cof = 1;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    public void Move()
    {
        _dist += Time.fixedDeltaTime * 10 * _cof;
        if (Mathf.Abs(_dist) > 5)
        {
            _cof *= -1;
            _dist = 0;
        }
        rb.velocity = Vector3.forward * _dist;    
    }

    
}
