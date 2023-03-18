using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    private float trashCanSpeed;

    private void Awake()
    {
        trashCanSpeed = 4f;
    }

    private void FixedUpdate()
    {
        transform.position += Time.deltaTime * trashCanSpeed * Vector3.left;
        MakeItHarder();
    }
    private void MakeItHarder()
    {
        if (Score.score > 15)
        {
            trashCanSpeed = 4.1f;
        }
        else if (Score.score > 20)
        {
            trashCanSpeed = 4.2f;
        }
        else if (Score.score > 25)
        {
            trashCanSpeed = 4.4f;
        }
        else if (Score.score > 40)
        {
            trashCanSpeed = 4.5f;
        }
        else if (Score.score > 45)
        {
            trashCanSpeed = 4.6f;
        }
        else if (Score.score > 50)
        {
            trashCanSpeed = 4.7f;
        }
        else if (Score.score > 75)
        {
            trashCanSpeed = 5f;
        }
        else if (Score.score > 95)
        {
            trashCanSpeed = 5.2f;
        }
        else if (Score.score > 100)
        {
            trashCanSpeed = 5.5f;
        }
    }
}
