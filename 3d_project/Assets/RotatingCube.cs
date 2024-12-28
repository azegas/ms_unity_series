using UnityEngine;

public class RotatingCube : MonoBehaviour
{
    public Vector3 editRotation;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Hello World!");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(editRotation);
    }
}
