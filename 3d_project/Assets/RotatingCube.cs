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
    }

    // Update is called once per frame
    void Update()
    {
        if (keyboard is null)
        {
            Debug.Log("No keyboard detected");
            return;
        }

        if (keyboard.wKey.isPressed)
        {
            // rotate the cube by x amount(set in the UI) rotation units per second and not by frame
            transform.Rotate(editRotation * Time.deltaTime);
            Debug.Log($"updated cube's rotation to - {transform.rotation}");
        }
    }
}
