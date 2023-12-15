using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public float enemySpeed = 10f;

    void OnTriggerEnter(Collider other)
    {
        // Check if the collision is with an object tagged as "Enemy"
        if (other.CompareTag("NPC"))
        {
            Debug.Log("Bullet hit the enemy");
           
            Destroy(other.gameObject); // Destroy the enemy

            // Optionally, you can perform additional actions when the enemy is destroyed
        }
    }
}