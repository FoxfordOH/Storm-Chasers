using UnityEngine;
using UnityEngine.UI;

public class WaterBossScript : MonoBehaviour
{
    GameObject waterBossRef;
    [SerializeField] Slider waterHealthBar;
    int waterHealth = 2000;
    GameObject playerRef;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        waterBossRef = GameObject.FindGameObjectWithTag("WaterBoss");
        playerRef = GameObject.FindGameObjectWithTag("Player");

            if (waterHealth <= 0) {
            Destroy(waterBossRef);
        }
    }

    // Update is called once per frame
    void Update()
    {
        waterHealthBar.value = waterHealth;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("bullet"))
        {
            waterHealth -= 20;
            Destroy(collision.gameObject);
        }
    }
}