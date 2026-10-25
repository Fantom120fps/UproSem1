using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotMechanic : MonoBehaviour, IRobot
{
    

    public void Greeting()
    {
        Debug.Log("Привет! я персоальный механик, а ты мой дружище!");
    }

    public void Use()
    {
        Debug.Log("Что вы хотите, чтобы я починил?");
    }
}
