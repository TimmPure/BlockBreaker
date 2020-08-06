using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private Vector2 paddleToBallVector;
    public Paddle paddle1;
    private Rigidbody2D rb2d;
    private bool hasStarted = false;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        paddleToBallVector = transform.position - paddle1.transform.position;
    }

    void Update() {
        if (!hasStarted) {
            LockToPaddle();
            LaunchOnMouseClick();
        }
    }

    private void LaunchOnMouseClick() {
        if (Input.GetMouseButtonDown(0)) {
            rb2d.velocity = new Vector2(2f, 15f);
            hasStarted = true;
            rb2d.simulated = true;
        }
    }

    private void LockToPaddle() {
        Vector2 paddlePos = new Vector2(paddle1.transform.position.x, paddle1.transform.position.y);
        transform.position = paddlePos + paddleToBallVector;
        rb2d.simulated = false;
    }
}
