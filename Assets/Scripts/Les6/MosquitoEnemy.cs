using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MosquitoEnemy : MonoBehaviour, IEnemy
{
    Rigidbody _rb;
    private float dist = 0;
    private int cof = 1;
    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }
    public void Move()
    {
        dist += Time.fixedDeltaTime * 10 * cof;

        if (Mathf.Abs(dist) > 5)
        {
            cof *= -1;
            dist = 0;
        }
        _rb.velocity = Vector3.up * dist;
    }
}
