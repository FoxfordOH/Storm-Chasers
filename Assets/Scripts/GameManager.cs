using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    [SerializeField] private GameObject player = null;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameStart();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void GameStart()
    {
    player.transform.position = new Vector3(0.0f, 0.0f, transform.position.z);
    }    
    
    public void GameQuit()
    {
        Application.Quit();
    }
}
