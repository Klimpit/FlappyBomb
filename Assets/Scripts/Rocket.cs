using System;
using UnityEngine;
using UnityEngine.UIElements;

public class Rocket : MonoBehaviour
{
    public Rigidbody2D rbd;
    [SerializeField]
    private float jumpForce = 8;
    [SerializeField]
    private float maxVelocity = 8;
    [SerializeField]
    private float gravityScale = 2f;
    [SerializeField]
    private Transform rocket;
    private float speedRotation;

    private void Awake()
    {
        rbd.gravityScale = 0;
    }

    private void Update()
    {
        Fly(Input.GetKeyDown(KeyCode.Space));
        Fly(Input.GetMouseButtonDown(0));
        rbd.velocity = Vector3.ClampMagnitude(rbd.velocity, maxVelocity);
        RocketRotation();
        if(Crash.isHadCrashed)
        {
            this.gameObject.SetActive(false);
        }
    }

    public void Fly(bool key)
    {
        if (GameManager.firstClick && key && Time.timeScale != 0f)
        {
            rbd.gravityScale = gravityScale;
        }
        if (key && Time.timeScale != 0f && Crash.isHadCrashed == false)
        {
            rbd.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            transform.SetPositionAndRotation(transform.position, Quaternion.Euler(0,0,12));
            speedRotation = -15;
        }

    }

    public void RocketRotation()
    {
        if (transform.rotation.z > -0.5 && GameManager.firstClick == false && Time.timeScale != 0f)
        {
            transform.Rotate(new Vector3(0, 0, speedRotation) * Time.deltaTime);
            speedRotation -= 10 * Time.fixedDeltaTime;
        }
    }
}
