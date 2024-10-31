using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovementScript : MonoBehaviour
{
    public float moveSpeed = 5f; // Liikkumisnopeus
    public float rotationSpeed = 100f; // Py�rimisnopeus

    private Rigidbody rb;
    private Vector3 movement;

    void Start()
    {
        // Haetaan Rigidbody-komponentti, jotta pelaajaa voidaan liikuttaa
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Saadaan sy�tteet X- ja Z-akselilla liikkumista varten
        movement.x = Input.GetAxis("Horizontal");
        //movement.z = Input.GetAxis("Vertical");

        // Py�ritet��n hahmoa Y-akselin ymp�ri
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.up, -rotationSpeed * Time.deltaTime); // Py�rii vasemmalle
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime); // Py�rii oikealle
        }
    }

    void FixedUpdate()
    {
        // Liikutetaan pelaajaa Rigidbody-komponentin avulla
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}
