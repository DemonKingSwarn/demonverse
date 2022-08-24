using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    [SerializeField] int damage = 10;
    [SerializeField] float range = 100f;

    [SerializeField] GameObject player;

    void Update()
    {
	if (Input.GetButtonDown("Fire1")) 
	{
	    Shoot();
	}     
    }

    void Shoot()
    {
	    RaycastHit hit;
        if(Physics.Raycast(player.transform.position, player.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);
            
            EnemyAI target = hit.transform.GetComponent<EnemyAI>();
            if (target != null) 
            {
                target.TakeDamage(damage);
            }
        }
    }
}
