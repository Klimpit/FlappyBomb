using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    private MeshRenderer meshRenderer;
    [SerializeField] private float speed = 1f;
    private Vector2 movement;

    private void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        movement = new Vector2(speed * Time.deltaTime, 0);
        meshRenderer.material.mainTextureOffset += movement;
    }
}
