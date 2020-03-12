using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody Rigidbody;
    public float forwardForce = 4000f;
    public float sidewayForce = 100f;
    public GameManager GameManager;
    public static bool GameIsPaused = false;


    private void FixedUpdate()
    {
        // Add a forward force to our sphere
        Rigidbody.AddForce(0, 0, (forwardForce * Time.fixedDeltaTime));
        

        if (Input.GetKey("d"))
        {
            //ForceMode.VelocityChange = Able to move instanlty, mass is ingnored.
            Rigidbody.AddForce(sidewayForce * Time.fixedDeltaTime, 0, 0, ForceMode.VelocityChange);


        }

        if (Input.GetKey("a"))
        {
            Rigidbody.AddForce(-sidewayForce * Time.fixedDeltaTime, 0, 0, ForceMode.VelocityChange);
        }

        // If the sphere y position falls below -1, the EndGame method is called.
        if(transform.position.y < - 1f )
        {
            GameManager.EndGame();
        }

        

    }
    
}
