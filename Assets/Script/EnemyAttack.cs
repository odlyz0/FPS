using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UIElements;

public class EnemyAttack : MonoBehaviour
{
    public Transform player;
    public float attackRange = 10f;
    private Enemy enemyScript;
    public Renderer ren;
    public Material defaultMaterial;
    public Material allertMaterial;

    // Start is called before the first frame update
    void Start()
    {
        
    }
   

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance (transform.position, player.position) <= attackRange)
        {
            ren.sharedMaterial = allertMaterial;
            enemyScript.badGuy.SetDestination(player.position); 
           
        }
        else
        {
            ren.sharedMaterial = defaultMaterial;
            enemyScript.newLocation();
        }

    }
}
