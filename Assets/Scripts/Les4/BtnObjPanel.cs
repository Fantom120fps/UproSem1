using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BtnObjPanel : ObjectPanelInfo
{

    [SerializeField]
    private Button btnLevelUp;

    private void Awake()
    {

        base.Awake();
        btnLevelUp.onClick.AddListener(() =>
        {
            Debug.Log("Level up Weapon!!");
        });
    }
}
