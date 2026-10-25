using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;


public class AnimButton : MonoBehaviour
{
    private void Start()
    {
        StartAnim();
    }

    private void StartAnim()
    {
        Sequence sequence = DOTween.Sequence();

        sequence.Append(GetComponent<RectTransform>().DOScale(new Vector3(0.8f, 0.8f, 0.8f), 1f));
        sequence.Append(GetComponent<RectTransform>().DOScale(new Vector3(1f, 1f, 1f), 1f));
        sequence.Append(GetComponent<RectTransform>().DORotate(new Vector3(0f, 360f, 0f), 3f, RotateMode.FastBeyond360));

        sequence.SetLoops(-1, LoopType.Restart);
    }
}
