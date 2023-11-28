using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Rendering;

public class Enemy : MonoBehaviour
{
    public NavMeshAgent badGuy;

    public float xMin;
    public float xMax;

    public float zMin;
    public float zMax;

    public float closeEnough = 3f;
   
    private float xPosition;
    private float yPosition;
    private float zPosition;

    void Start()
    {
        newLocation();
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, new Vector3(xPosition, yPosition, zPosition)) <= closeEnough)
        {
            newLocation();
        }
    }

    public void newLocation()
    {
        xPosition = Random.Range(xMin, xMax);
        yPosition = transform.position.y;
        zPosition = Random.Range(zMin, zMax);
        badGuy.SetDestination(new Vector3(xPosition, yPosition, zPosition));
    }

}
