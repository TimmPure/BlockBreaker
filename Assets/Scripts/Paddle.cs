using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    [SerializeField] float screenWidthInUnits = 16f;

    void Update() {
        movePaddleToMouseX();
    }

    private void movePaddleToMouseX() {
        float mouseXPosInUnits = Input.mousePosition.x / Screen.width * screenWidthInUnits;
        Vector2 paddlePos = new Vector2(mouseXPosInUnits, transform.position.y);
        transform.position = paddlePos;
    }
}
