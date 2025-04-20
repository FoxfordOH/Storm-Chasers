using UnityEngine;
using UnityEngine.UI;
public class SnowBossScript : MonoBehaviour
{
    GameObject snowBossRef;
    [SerializeField] Slider snowHealthBar;
    int snowHealth = 3000;
    GameObject playerRef;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        snowBossRef = GameObject.FindGameObjectWithTag("SnowBoss");
        playerRef = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        snowHealthBar.value = snowHealth;

                if (snowHealth <= 0) {
            Destroy(snowBossRef);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("bullet"))
        {
            snowHealth -= 20;
            Destroy(collision.gameObject);
        }
    }
}
