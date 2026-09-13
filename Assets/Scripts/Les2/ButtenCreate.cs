using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtenCreate : MonoBehaviour, IbuttenPortal
{
    [SerializeField] private GameObject prefabPortal;
    [SerializeField] private Vector3 positionPortal;

    public void ClickButton()
    {
        Instantiate(prefabPortal, positionPortal, Quaternion.identity);
    }
}
