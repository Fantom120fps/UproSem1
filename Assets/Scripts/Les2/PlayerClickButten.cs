using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerClickButten : MonoBehaviour 
{
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out RaycastHit hit))

                hit.collider.GetComponent<IbuttenPortal>()?.ClickButton();

        }
    }

    
}
