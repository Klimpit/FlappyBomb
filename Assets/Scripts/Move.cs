using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public static float tubeSpeed = 4.3f;

    private void FixedUpdate()
    {
        transform.position += Time.deltaTime * tubeSpeed * Vector3.left;
    }

    public static void ChangeSpeed(ref float speed)
    {
        speed += 0.01f;
    }
}
