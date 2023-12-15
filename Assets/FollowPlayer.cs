using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField] private float shootingInterval = 1f;
    private float bulletTime;
    public Transform targetObj;

    public GameObject enemyBullet;
    public Transform spawnPoint;
    public float enemySpeed;

    void Start()
    {
        bulletTime = shootingInterval;
    }

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, targetObj.position, 10 * Time.deltaTime);
        ShootAtPlayer();
    }

    void ShootAtPlayer()
    {
        bulletTime -= Time.deltaTime;

        if (bulletTime <= 0)
        {
            GameObject bulletObj = Instantiate(enemyBullet, spawnPoint.position, spawnPoint.rotation) as GameObject;
            Rigidbody bulletRig = bulletObj.GetComponent<Rigidbody>();

            Vector3 directionToPlayer = (targetObj.position - spawnPoint.position).normalized;
            bulletRig.AddForce(directionToPlayer * enemySpeed);

            Destroy(bulletObj, 2f); // Destroy the bullet after 5 seconds (you can adjust this time)

            bulletTime = shootingInterval;
        }
    }

    

}
