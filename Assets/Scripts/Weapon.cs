using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public GameObject bullet;

    public Transform firePoint;

    public float fireForce;

    

    private void Start()
    {
        
    }
    public void Fire()
    {
        GameObject projectile = Instantiate(bullet, firePoint.position, firePoint.rotation);
        projectile.GetComponent<Rigidbody2D>().AddForce(firePoint.up * fireForce, ForceMode2D.Impulse);

        Destroy(projectile, 2.0f);
       

    }


}
