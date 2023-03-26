using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeItHarder : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Move.ChangeSpeed(ref Move.tubeSpeed);
        Spawner.ChangeTimer(ref Spawner.maxTime);
        Debug.Log("picking up speed");
    }
}
