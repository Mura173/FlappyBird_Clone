using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    Button play;

    void Start()
    {
        play = GetComponent<Button>();
    }

    
    void Update()
    {
        
    }

    public void Jogar()
    {
        SceneManager.LoadScene(0);
    }
}
