using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class ScoreTrigger : MonoBehaviour
{
    [SerializeField] private AudioSource score;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Score.score++;
        score.Play();
    }
}

