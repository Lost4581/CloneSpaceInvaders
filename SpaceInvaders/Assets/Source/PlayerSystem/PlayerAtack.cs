using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerAtack : MonoBehaviour
{
    [SerializeField] private GameObject bulletPref;
    [SerializeField] private Transform firePoint;
    [SerializeField] private int ReloadTime;
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
        StartCoroutine(Reload());
        Instantiate(bulletPref, firePoint.position, firePoint.rotation);
    }
    IEnumerator Reload()
    {
        canShoot = false;
        yield return new WaitForSeconds(ReloadTime);
        canShoot = true;
    }
}
