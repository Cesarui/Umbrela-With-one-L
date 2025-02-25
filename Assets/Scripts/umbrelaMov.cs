using UnityEngine;

public class umbrelaMov : MonoBehaviour
{
    private float speed = 10.0f;
    private float horizontalInput;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Input for the x axist(Horizontal)
        horizontalInput = Input.GetAxis("Horizontal");

        // Speed for moving left and right 
        transform.Translate(Vector3.right * speed * Time.deltaTime * horizontalInput);
    }
}
