using System;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    [SerializeField] private GameObject player = null;
    [SerializeField] private GameObject StartMenu = null;   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    StartMenu.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void GameStart()
    {
    player.transform.position = new Vector3(0.0f, 0.0f, transform.position.z);
    StartMenu.SetActive(false);
    }    
}
