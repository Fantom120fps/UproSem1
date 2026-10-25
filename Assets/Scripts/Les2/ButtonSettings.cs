using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonSettings : MonoBehaviour, IBottonPortal
{
    public void ClickButton()
    {
        FindObjectOfType<Portal>()?.transform.GetChild(0).gameObject.SetActive(true);
    }
}
