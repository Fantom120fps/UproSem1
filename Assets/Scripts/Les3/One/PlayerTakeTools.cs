using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTakeTools : MonoBehaviour
{
    [SerializeField]
    private Transform position;

    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKey(KeyCode.E))
            if (GetComponent<ITool>() == null)
                other.GetComponent<ITool>()?.Take(position.localPosition, transform);
    }
}