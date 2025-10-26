using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerAtack : MonoBehaviour
{
    [SerializeField] private GameObject bulletPref;
    [SerializeField] private Transform firePoint;

    private bool canShoot = true;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Atack(bulletPref);
        }
    }

    private void Atack(GameObject bullet)
    {
        Instantiate(bullet, firePoint.position, firePoint.rotation);
    }
}