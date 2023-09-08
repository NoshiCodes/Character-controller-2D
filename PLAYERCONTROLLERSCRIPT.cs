using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLAYERCONTROLLERSCRIPT : MonoBehaviour
{
    public Rigidbody2D myrigidbody;
    public float jumpspeed = 1000f;
    public float movementspeed = 750f;

    void Start()
    {
        myrigidbody = GetComponent<Rigidbody2D>(); // Assuming the Rigidbody2D is on the same GameObject
    }

    void Update()
    {
        Vector2 newVelocity = myrigidbody.velocity; // Store the current velocity

        if (Input.GetKey("space"))
        {
            newVelocity.y = jumpspeed * Time.deltaTime; // Only change the vertical component we used ".y" to assign only they y component of velocity
        }

        if (Input.GetKey("a"))
        {
            newVelocity.x = -movementspeed * Time.deltaTime; // Modify the horizontal component
        }
        else if (Input.GetKey("d"))
        {
            newVelocity.x = movementspeed * Time.deltaTime; // Modify the horizontal component
        }
        else
        {
            newVelocity.x = 0f; // No horizontal input, stop horizontal movement
        }

        myrigidbody.velocity = newVelocity; // Set the modified velocity back to the Rigidbody
    }
}
