using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotWaiter : MonoBehaviour, IRobot, IWailter
{
    [SerializeField] protected GameObject _coffee;
    public virtual void Bring()
    {
        Debug.Log("Вот ваш кофе, Сэр");
        Instantiate(_coffee, transform.position + new Vector3(0f, 1f, -1f), Quaternion.identity);
    }

    public void Greeting()
    {
        Debug.Log("Привет! я робот-ждун, подожду!");
    }

    public void Use()
    {
        Debug.Log("Я принесу вам кофе!");
    }
}
