using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtenSetting : MonoBehaviour, IbuttenPortal
{
    public void ClickButton()
    {
        FindObjectOfType<Portal>()?.transform.GetChild(0).gameObject.SetActive(true);
    }
}
