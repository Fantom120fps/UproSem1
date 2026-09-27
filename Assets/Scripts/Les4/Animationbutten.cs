using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class Animationbutten : MonoBehaviour
{
    private void Start()
    {
        Sequence sequence = DOTween.Sequence();
        sequence.Append(GetComponent<RectTransform>().DOShakePosition(1f, 10f,10,90f));
        sequence.SetLoops(-1, LoopType.Restart);
    }
}
