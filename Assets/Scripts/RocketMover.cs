using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketMover : MonoBehaviour
{

    Rigidbody rb;

    [Tooltip("Rocket Thurst")]
    public float thurst;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        MovementAxes();
    }
    private void MovementAxes()
    {
        float hInput = Input.GetAxis("Horizontal");
        float vInput = Input.GetAxis("Vertical");
        rb.AddRelativeForce(new Vector3(0, vInput, 0) * Time.deltaTime * thurst);

        ApplyRotation(hInput);


        // transform.Translate(new Vector3(0, vInput, hInput) * Time.deltaTime * speed);
        // transform.position += new Vector3(vInput,0.5f, hInput);    
    }

    void ApplyRotation(float rotationThisFrame)
    {
        rb.freezeRotation = true; //freezing rotation so we can manually rotate
        transform.Rotate(new Vector3(0, 0, rotationThisFrame) * Time.deltaTime * thurst);
        rb.freezeRotation = false; //unfreezing rotation so 
    }


}
