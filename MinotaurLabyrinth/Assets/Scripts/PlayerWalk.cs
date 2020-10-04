using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWalk : MonoBehaviour
{
    float horizontal;
    float vertical;

    public float runSpeed = 20.0f;
    private Rigidbody2D body;

    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
        body.velocity = new Vector2(horizontal * runSpeed, vertical * runSpeed);
    }
}
