using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    // Viite projektiili-prefabiin
    public GameObject projectilePrefab;

    // Ammunnan voima/projektiilin nopeus
    public float projectileSpeed = 20f;

    // Mist‰ projektiili l‰htee
    public Transform shootPoint;

    void Update()
    {
        // Tarkistaa, onko hiiren vasenta painiketta painettu
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        // Luo projektiilin annettuun paikkaan ja suuntaan
        GameObject projectile = Instantiate(projectilePrefab, shootPoint.position, shootPoint.rotation);

        // Lis‰‰ voiman projektiilille, jotta se liikkuu eteenp‰in
        Rigidbody rb = projectile.GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.velocity = shootPoint.forward * projectileSpeed;
        }
    }
}
