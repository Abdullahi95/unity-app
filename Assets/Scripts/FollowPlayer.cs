using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform Player;
    public Vector3 adjustment;


    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = Player.transform.position + adjustment;
    }
}
