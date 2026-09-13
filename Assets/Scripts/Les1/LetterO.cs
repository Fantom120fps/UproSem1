using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class LetterO : MonoBehaviour, ILetter
{
    private Renderer rend;
    private Color currentColor;

    private void Start()
    {
        rend = GetComponent<Renderer>();
        currentColor = rend.material.color;
    }
    public void MousHovered()
    {
        Sequence sequence = DOTween.Sequence();

        sequence.Append(rend.material.DOColor(Random.ColorHSV(), 1f));
        sequence.AppendInterval(2);
        sequence.Append(rend.material.DOColor(currentColor, 1f));

        sequence.Play();
    }
}
