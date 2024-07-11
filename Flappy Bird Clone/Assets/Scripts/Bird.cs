using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bird : MonoBehaviour
{
    Rigidbody2D rb;

    // Variáveis Públicas
    public float speed;
    public float jumpForce;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        transform.Translate(speed, 0, 0);

        if (Input.GetButton("Jump"))
        {
            rb.AddForce(transform.up * jumpForce, ForceMode2D.Force);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Cano"))
        {
            SceneManager.LoadScene(0);
        }
    }
}
