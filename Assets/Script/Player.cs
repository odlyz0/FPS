using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject ball;
    public GameObject playerCamera;

    public float ballDistance = 2f;
    public float ballThrowingForce = 5f;

    private bool holdingBall = true;
  
    void Start()
    {
        ball.GetComponent<Rigidbody> ().useGravity = false;
    }

    void Update()
    {
        if (holdingBall)
        {
            ball.transform.position = playerCamera.transform.position +
            playerCamera.transform.forward * ballDistance;
            if (Input.GetMouseButtonDown(0))
            {
                holdingBall = false;
                ball.GetComponent<Rigidbody>().useGravity = true;
                ball.GetComponent<Rigidbody>().AddForce(playerCamera.transform.forward * ballThrowingForce);

            }
        }

        else
        {
            // Check for right mouse button click to pick up the ball again
            if (Input.GetMouseButtonDown(1))
            {
                holdingBall = true;
                ball.GetComponent<Rigidbody>().useGravity = false;
                ball.GetComponent<Rigidbody>().velocity = Vector3.zero;
                ball.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
            }
        }
    }
}
