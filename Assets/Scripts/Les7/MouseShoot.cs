using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseShoot : MonoBehaviour
{
    [SerializeField]
    private float forceShoot = 10;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                if (hit.collider.GetComponentInParent<IDamage>() != null)
                {
                    Vector3 direction = (hit.point - Camera.main.transform.position).normalized;
                    direction.y = 0;

                    hit.collider.GetComponentInParent<IDamage>().TakeDamage(direction * forceShoot, hit.point);
                }
            }
        }
    }
}
