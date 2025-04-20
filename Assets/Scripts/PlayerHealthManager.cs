using UnityEngine;

public class PlayerHealthManager : MonoBehaviour
{
    public GameObject playerRef;
    public int playerHealth = 100;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerRef = this.gameObject;
        playerHealth = 100;
    }

    // Update is called once per frame
    void Update()
    {
        if (playerHealth <= 0) {
            Destroy(playerRef);
        }        
    }
}
