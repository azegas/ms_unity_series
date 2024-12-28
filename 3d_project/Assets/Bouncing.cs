using UnityEngine;

public class Bouncing : MonoBehaviour
{
    public Rigidbody rb;
    public Vector3 force;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Bouncing component init");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "Floor")
        {
            Debug.Log("landed on the floor");
            rb.AddForce(force);
        }
    }
}
