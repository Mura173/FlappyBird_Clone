using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPipes : MonoBehaviour
{
    public GameObject pipe;
    public float height;
    public float maxTime;

    private float timer = 0f;

    void Start()
    {
        // Criar uma cópia do objeto
        GameObject newPipe = Instantiate(pipe);

        //Posição do conjunto de cano será a posição do spawner + uma nova posição, sorteando um valor randomico no Y
        newPipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
    }

    
    void Update()
    {
        if (timer > maxTime)
        {
            GameObject newPipe = Instantiate(pipe);
            newPipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
            Destroy(newPipe, 20f);
            timer = 0;
        }

        timer += Time.deltaTime;
    }
}
