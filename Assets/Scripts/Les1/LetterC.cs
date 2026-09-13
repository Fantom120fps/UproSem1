using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class LetterC : MonoBehaviour, ILetter
{
    private Renderer rend;

    private void Start()
    {
        rend = GetComponent<Renderer>();
    }
    public void MousHovered()
    {
        Sequence sequence = DOTween.Sequence();

        sequence.Append(rend.material.DOFade(0f, 1f));
        sequence.AppendInterval(2);
        sequence.Append(rend.material.DOFade(1f, 1f));

        sequence.Play();
    }
}

