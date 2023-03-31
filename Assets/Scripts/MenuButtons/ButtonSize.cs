using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonSize : MonoBehaviour
{
    [Range(0f, 1f)]
    public float AlphaLevel = 1f;
    private Image bt;

    void Start()
    {
        bt = gameObject.GetComponent<Image>();
        bt.alphaHitTestMinimumThreshold = AlphaLevel;
    }
}
