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
        
    }
}
