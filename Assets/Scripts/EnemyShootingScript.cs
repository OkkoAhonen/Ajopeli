using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShootingScript : MonoBehaviour
{
    public GameObject projectilePrefab;  // Projektiilin prefab, joka on liitett�v� Unity-editorissa
    public Transform firePoint;  // Piste, josta projektiili l�htee
    public float projectileSpeed = 10f;  // Projektiilin nopeus
    public float shootInterval = 1f;  // Aika ampumisten v�lill� sekunteina

    private float shootTimer;

    void Update()
    {
        // Laskee ajan edellisest� laukauksesta
        shootTimer += Time.deltaTime;

        // Jos aika ampumisten v�lill� on t�ynn�, vihollinen ampuu
        if (shootTimer >= shootInterval)
        {
            Shoot();
            shootTimer = 0f;  // Nollaa ajastimen
        }
    }

    void Shoot()
    {
        // Luo projektiilin ja aseta se ampumispisteeseen
        GameObject projectile = Instantiate(projectilePrefab, firePoint.position, firePoint.rotation);

        // Aseta projektiilin nopeus
        Rigidbody rb = projectile.GetComponent<Rigidbody>();
        rb.velocity = firePoint.forward * projectileSpeed;
    }
}
