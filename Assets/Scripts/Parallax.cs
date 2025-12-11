using UnityEngine;

public class Parallax : MonoBehaviour
{
    [SerializeField] private float speed = 1f;

    private MeshRenderer meshRenderer;
    private Vector2 movement;

    private void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }
    
    void FixedUpdate()
    {
        movement = new Vector2(speed * Time.deltaTime, 0);
        meshRenderer.material.mainTextureOffset += movement;
    }
}
