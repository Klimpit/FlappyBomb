using System.Collections;
using UnityEngine;
using static UnityEngine.InputSystem.InputAction;

public class Rocket : MonoBehaviour, IObserver
{
    private Rigidbody2D rbd;

    public static bool IsCrashed {  get; private set; }

    [SerializeField] private float jumpForce = 8;
    [SerializeField] private float maxVelocity = 8;
    [SerializeField] private float gravityScale = 2f;

    private float speedRotation;

    private void Awake()
    {
        rbd = GetComponent<Rigidbody2D>();
        rbd.gravityScale = 0;
        IsCrashed = false;
        speedRotation = 0;
    }
    private void FixedUpdate()
    {
        rbd.linearVelocity = Vector3.ClampMagnitude(rbd.linearVelocity, maxVelocity);
    }
    public void Fly(CallbackContext context)
    {
        if (context.performed)
        {
            rbd.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            transform.SetPositionAndRotation(transform.position, Quaternion.Euler(0,0,12));
            speedRotation = -15;
        }
    }
    private void Crash(Collision2D collision)
    {
        if (collision.gameObject.layer == 7 || collision.gameObject.layer == 6)
        {
            IsCrashed = true;
            Debug.Log("GG!");
            this.gameObject.SetActive(!IsCrashed);
        }
    }
    private IEnumerator RocketRotation()
    {
        while (true)
        {
            if (transform.rotation.z > -0.5)
            {
                transform.Rotate(new Vector3(0, 0, speedRotation) * Time.deltaTime);
                speedRotation -= 10 * Time.fixedDeltaTime;
            }
            yield return new WaitForFixedUpdate();
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Crash(collision);
    }
    public void UpdateOnStartGame()
    {
        rbd.gravityScale = gravityScale;
        StartCoroutine(RocketRotation());
    }
    public void UpdateOnEndGame()
    {
        Destroy(this);
    }
}
