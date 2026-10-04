using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IWaiterSmall : RobotWaiter
{
    [SerializeField] private GameObject _watter;

    public override void Bring()
    {
        base.Bring();
        Debug.Log("Вот ваша вода, Сэр");
        Instantiate(_watter, transform.position + new Vector3(0f, 1f, -1f), Quaternion.identity);
    } 
}
