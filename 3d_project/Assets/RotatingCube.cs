using UnityEngine;
using UnityEngine.InputSystem;

public class RotatingCube : MonoBehaviour
{
    public Vector3 editRotation;
    public Vector3 editPosition;

    // create a public variable for a keyboard
    public Keyboard keyboard;

    // declare startPosition as a class-level variable
    private Vector3 startPosition;

    // declare a speed variable - one unit per second
    public float speed = 1.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Hello World!");

        // assign current active keyboard to kayboard variable
        keyboard = Keyboard.current;

        startPosition = transform.position;

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
            transform.position += new Vector3(0, 0, 1) * speed * Time.deltaTime;
            Debug.Log("W is pressed");
            Debug.Log($"updated cube's position to - {transform.position}");
        }

        if (keyboard.aKey.isPressed)
        {
            transform.position += new Vector3(1, 0, 0) * speed * Time.deltaTime;
            Debug.Log("A is pressed");
            Debug.Log($"updated cube's position to - {transform.position}");
        }

        if (keyboard.sKey.isPressed)
        {
            transform.position += new Vector3(0, 0, -1) * speed * Time.deltaTime;
            Debug.Log("S is pressed");
            Debug.Log($"updated cube's position to - {transform.position}");
        }

        if (keyboard.dKey.isPressed)
        {
            transform.position += new Vector3(-1, 0, 0) * speed * Time.deltaTime;
            Debug.Log("D is pressed");
            Debug.Log($"updated cube's position to - {transform.position}");
        }

        if (keyboard.escapeKey.isPressed)
        {
            transform.position = startPosition;
            Debug.Log("ESC is pressed");
            Debug.Log($"updated cube's position to - {startPosition}");
        }

        if (keyboard.rKey.isPressed)
        {
            // rotate the cube by x amount(set in the UI) rotation units per second and not by frame
            transform.Rotate(editRotation * Time.deltaTime);
            Debug.Log($"updated cube's rotation to - {transform.rotation}");
        }

        if (keyboard.spaceKey.isPressed)
        {
            transform.position += new Vector3(0, 1, 0) * speed * Time.deltaTime;
        }
    }
}
