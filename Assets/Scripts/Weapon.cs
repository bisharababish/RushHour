using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
  public Transform firePoint; // where the bullet will be started from.
  public GameObject bulletPrefab; // Bullet it self.
    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1")) // Firing the bullet when clicking the right Side of the mouse.
        {
        Shoot();
        }
    }
    void Shoot()
    {
        Instantiate(bulletPrefab, firePoint.position,firePoint.rotation);
    }
}
