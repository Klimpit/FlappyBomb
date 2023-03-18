using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireTrigger : MonoBehaviour
{
    [SerializeField] private GameObject fire;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        fire.SetActive(true);
        Invoke(nameof(EndOfAnimation), 1.5f);
    }
    private void EndOfAnimation()
    {
        fire.SetActive(false);
    }
}
