using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brush : MonoBehaviour, ITool
{
    [SerializeField]
    Vector3 rotation;

    public void Take(Vector3 position, Transform parent)
    {
        transform.parent = parent;
        transform.localPosition = position;
        transform.localRotation = Quaternion.Euler(rotation);
    }

    public void Throw()
    {
        transform.parent = null;
    }

    public void Use()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out RaycastHit hit))
            hit.collider.GetComponent<IBuildingBlock>()?.ColorReset();
    }
}
