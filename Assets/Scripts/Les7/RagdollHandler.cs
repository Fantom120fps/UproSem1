using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class RagdollHandler : MonoBehaviour
{
    private List<Rigidbody> _rbs;

    public void Initialize()
    {
        _rbs = new List<Rigidbody>(GetComponentsInChildren<Rigidbody>());
        Disable();
    }

    public void Hit(Vector3 force, Vector3 hitPosition)
    {
        Rigidbody rb = _rbs.OrderBy(rb => Vector3.Distance(rb.position, hitPosition)).First();
        rb.AddForceAtPosition(force, hitPosition, ForceMode.Impulse);
    }

    public void Enable()
    {
        foreach (Rigidbody rb in _rbs)
        {
            rb.isKinematic = false;
        }
    }

    public void Disable()
    {
        foreach (Rigidbody rb in _rbs)
        {
            if (!rb.gameObject.GetComponent<Sword>())
                rb.isKinematic = true;
        }
    }

}
