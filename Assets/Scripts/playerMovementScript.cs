using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovementScript : MonoBehaviour
{
    public float moveSpeed = 5f; // Liikkumisnopeus
    public float rotationSpeed = 1000f; // Pyörimisnopeus

    private Rigidbody rb;
    private Vector3 movement;

    void Start()
    {
        // Haetaan Rigidbody-komponentti, jotta pelaajaa voidaan liikuttaa
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Saadaan syötteet X- ja Z-akselilla liikkumista varten
        movement.x = Input.GetAxis("Horizontal");
        //movement.y = Input.GetAxis("Vertical");

        // Pyöritetään hahmoa Y-akselin ympäri
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, 0, -rotationSpeed * Time.deltaTime);
            // Pyörii vasemmalle
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, 0, +rotationSpeed * Time.deltaTime); // Pyörii oikealle
        }
    }

    void FixedUpdate()
    {
        // Liikutetaan pelaajaa Rigidbody-komponentin avulla
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}
