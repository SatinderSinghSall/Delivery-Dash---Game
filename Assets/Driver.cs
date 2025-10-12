using UnityEngine;
using UnityEngine.InputSystem;

public class Driver : MonoBehaviour
{
    [SerializeField] float moveSpeed = 15f;
    [SerializeField] float steerSpeed = 300f;

    void Update()
    {
        float steer = 0f;
        float move = 0f;

        if (Keyboard.current.wKey.isPressed)
        {
            move = 1f;
        }

        else if (Keyboard.current.sKey.isPressed)
        {
            move = - 1f;
        }

        if (Keyboard.current.aKey.isPressed)
        {
            steer = 1f;
        }

        else if (Keyboard.current.dKey.isPressed)
        {
            steer = -1;
        }

        float moveAmount = move * moveSpeed * Time.deltaTime;
        float steerAmount = steer * steerSpeed * Time.deltaTime;

        transform.Translate(0, moveAmount, 0);
        transform.Rotate(0, 0, steerAmount);
    }
}
