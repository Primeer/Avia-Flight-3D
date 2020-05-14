using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ObjectRotator : MonoBehaviour
{
    public DragHandler inputHandler;
    public float rotationSpeed;

    public float inertion = 20;

    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        var rotation = inputHandler.PlayerInput * rotationSpeed * Time.fixedDeltaTime;

        if (!inputHandler.Pressed && inputHandler.LastMagnitude >= 2.5f)
        {
            if (rb.angularVelocity.sqrMagnitude == 0)
            {
                rb.AddTorque(Vector3.up * inputHandler.LastPlayerInput.x * inertion);
                rb.AddTorque(Vector3.right * inputHandler.LastPlayerInput.y * inertion);
            }
            else
            {
                rb.angularVelocity *= 0.97f;
            }
        }
        else
        {
            if (rb.angularVelocity.sqrMagnitude > 0)
            {
                rb.angularVelocity = Vector3.zero;
            }

            var eulerRotation = Quaternion.Euler(new Vector3(rotation.y, rotation.x)) * transform.rotation;
            // var eulerRotation = Quaternion.Euler(new Vector3(0, rotation.x)) * transform.rotation;
            rb.rotation = eulerRotation;
        }
    }
}