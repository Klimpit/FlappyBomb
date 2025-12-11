using UnityEngine;

public class ScoreTrigger : MonoBehaviour
{
    [SerializeField] private AudioSource scoreAudio;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Score.SetNewScore();
        //scoreAudio.Play();
    }
}

