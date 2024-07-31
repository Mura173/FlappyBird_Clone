using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point : MonoBehaviour
{
    GameManager manager;

    void Start()
    {
        manager = FindObjectOfType<GameManager>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        manager.score++;
        manager.scoreText.text = manager.score.ToString();
    }
}
