using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMechanic : MonoBehaviour
{
    GameObject backGround;
    GameObject bird;
    Camera cam;

    public float speed;

    void Start()
    {
        backGround = GameObject.Find("BackGround");
        bird = GameObject.Find("Bird");
        cam = Camera.main;
    }

    
    void FixedUpdate()
    {
        backGround.transform.Translate(speed, 0, 0);
        bird.transform.Translate(speed, 0, 0);
        cam.transform.Translate(speed, 0, 0);
    }
}
