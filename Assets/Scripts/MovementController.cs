using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    public float velocidad = 6.0f;
    public Vector2 movimiento;
    Rigidbody2D  rb;
    private float moveX, moveY;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        movimiento.x = Input.GetAxisRaw("Horizontal");
        movimiento.y = Input.GetAxisRaw("Vertical");

        movimiento.Normalize();
        rb.velocity = movimiento * velocidad;
    }
}
