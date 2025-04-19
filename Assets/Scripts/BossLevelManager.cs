using UnityEngine;

public class BossLevelManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private GameObject playerCamera = null;
    
    void Start()
    {
        playerCamera = GameObject.FindWithTag("MainCamera");
        playerCamera.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
