using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonStart : MonoBehaviour, IBottonPortal
{
    public void ClickButton()
    {
        FindObjectOfType<Portal>()?.transform.GetChild(1).gameObject.SetActive(true);
    }
}
