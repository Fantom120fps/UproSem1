using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionsOnRobot : MonoBehaviour
{
    private void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out RaycastHit hit))
        {
            if (hit.collider.GetComponent<IRobot>() != null)
            {
                if (Input.GetKeyDown(KeyCode.Alpha1))
                    hit.collider.GetComponent<IRobot>()?.Greeting();
                if (Input.GetKeyDown(KeyCode.Alpha2))
                    hit.collider.GetComponent<IRobot>()?.Use();
                if (Input.GetKeyDown(KeyCode.Alpha3))
                    hit.collider.GetComponent<IWailter>()?.Bring();

            }
        }
    }
}
