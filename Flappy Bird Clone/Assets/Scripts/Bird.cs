using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bird : MonoBehaviour
{
    Rigidbody2D rb;

    // Variáveis Públicas
    public float speed;

    public GameObject gameOver;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {

        if (Input.GetButton("Jump") || Input.GetMouseButton(0) )
        {
            rb.velocity = Vector2.up * speed;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        gameOver.SetActive(true);

        Time.timeScale = 0;
    }
}
