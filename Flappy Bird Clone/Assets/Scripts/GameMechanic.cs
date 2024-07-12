using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMechanic : MonoBehaviour
{
    GameObject backGround;
    Camera cam;

    // Colliders
    GameObject colliderBaixo;
    GameObject colliderCima;

    public float speed;

    void Start()
    {
        backGround = GameObject.Find("BackGround");
        cam = Camera.main;

        colliderBaixo = GameObject.Find("ColliderBaixo");
        colliderCima = GameObject.Find("ColliderCima");
    }
    
    void FixedUpdate()
    {
        Movimento();
    }

    void Movimento()
    {
            backGround.transform.Translate(speed, 0, 0);
            cam.transform.Translate(speed, 0, 0);
            colliderBaixo.transform.Translate(speed, 0, 0);
            colliderCima.transform.Translate(speed, 0, 0);
    }
}
