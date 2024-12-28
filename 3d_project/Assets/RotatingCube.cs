using UnityEngine;

public class RotatingCube : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Hello World!");
        transform.Rotate(0, 45, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
