using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovementScript : MonoBehaviour
{
    public float moveSpeed = 5f; // Liikkumisnopeus

    private Rigidbody rb;
    private Vector3 movement;

    void Start()
    {
        // Haetaan Rigidbody-komponentti, jotta pelaajaa voidaan liikuttaa
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Saadaan syötteet X- ja Z-akselilla
        movement.x = Input.GetAxis("Horizontal");
        movement.y = Input.GetAxis("Vertical");
    }

    void FixedUpdate()
    {
        // Liikutetaan pelaajaa Rigidbody-komponentin avulla
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}