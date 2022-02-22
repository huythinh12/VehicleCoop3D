using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float speed;
    private float spinSpeed = 1000;
    public float rotationSpeed;
    public float verticalInput;
    public GameObject proppeller;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // get the user's vertical input
        verticalInput = Input.GetAxis("Horizontal");
        rotationSpeed = Input.GetAxis("Vertical");
        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * Time.deltaTime* speed* verticalInput);

        // tilt the plane up/down based on up/down arrow keys
        transform.Rotate(Vector3.left * speed* rotationSpeed * Time.deltaTime);

        proppeller.transform.Rotate(Vector3.forward, Time.deltaTime * spinSpeed );

    }
}
