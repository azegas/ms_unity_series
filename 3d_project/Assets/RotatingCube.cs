using UnityEngine;
using UnityEngine.InputSystem;

public class RotatingCube : MonoBehaviour
{
    public Vector3 editRotation;

    // create a public variable for a keyboard
    public Keyboard keyboard;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Hello World!");
  
        // assign current active keyboard to kayboard variable
        keyboard = Keyboard.current;

        if (keyboard != null)
        {
            Debug.Log($"Keyboard detected: {keyboard}.");
        }
        else
        {
            Debug.Log($"No keyboard detected: {keyboard}.");
            return;
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (keyboard.wKey.isPressed)
        {
            Debug.Log("w key is pressed");
        }
        transform.Rotate(editRotation);
    }
}
