using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    [SerializeField] float screenWidthInUnits = 16f;
    [SerializeField] float paddleMaxX = 15f;
    [SerializeField] float paddleMinX = 1f;

    void Update() {
        movePaddleToMouseX();
    }

    private void movePaddleToMouseX() {
        float mouseXPosInUnits = Input.mousePosition.x / Screen.width * screenWidthInUnits;
        Vector2 paddlePos = new Vector2(Mathf.Clamp(mouseXPosInUnits,paddleMinX,paddleMaxX), transform.position.y);
        transform.position = paddlePos;
    }
}
