using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    // Start is called before the first frame update

    public float maximum = 2.0f;  // maximum x value of the obstacle.
    public float minimum = -2.0f; // minimum x value of the obstacle.
    public float t = 0.0f;

    void FixedUpdate()
    {
        // Lerp function allows you to move an object gradually between those points. Interpolates between the points a and b by the interpolant t.

        transform.position = new Vector3(Mathf.Lerp(minimum, maximum, t), transform.position.y, transform.position.z);

         t +=  0.5f * Time.deltaTime; // speed of the obstacle

        // Time.fixedDeltaTime, Time.deltaTime is the time passed since last frame

        if (t > 1.0f)                   // When t is set to be greater than 0 the obstacle pauses at the edge before carrying on.
        {
            float temp = maximum;
            maximum = minimum;
            minimum = temp;
            t = 0.0f;

        }

    }
}
