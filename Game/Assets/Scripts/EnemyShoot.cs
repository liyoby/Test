using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{

    public float timeTweenShots;
    public float startTimeTweenShots;

    public GameObject bullet;

    public Transform target;


    void Start()
    {
        timeTweenShots = startTimeTweenShots;
    }

    void Update()
    {
        shootBullet();
    }

    void shootBullet()
    {
        if (timeTweenShots <= 0)
        {
            Instantiate(bullet, transform.position, Quaternion.identity);
            timeTweenShots = startTimeTweenShots;
        }
        else
        {
            timeTweenShots -= Time.deltaTime;
        }
    }


   
}
