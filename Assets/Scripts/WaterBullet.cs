using UnityEngine;

public class WaterBullet : MonoBehaviour
{
    GameObject bullet;
    GameObject gunManager;
    Rigidbody2D bulletRB;
    GameObject screenCenter;
    [SerializeField] float bulletSpeed = 4;
    GameObject playerRef;
    PlayerHealthManager playerHealthScript;
    int bulletHealth = 100;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        bullet = this.gameObject;
        bulletRB = this.GetComponent<Rigidbody2D>();
        playerRef = GameObject.FindGameObjectWithTag("Player");
        playerHealthScript = playerRef.GetComponent<PlayerHealthManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (bulletHealth <= 0) {
            Destroy(bullet);
        }
        
        bulletRB.transform.Translate(Vector2.left * bulletSpeed * Time.deltaTime);

// SET BOUNDS TO PLAYABLE AREA SIZE (If that's what we do)
        if (bullet.transform.position.y > 100f|| 
        bullet.transform.position.y < -100f || 
        bullet.transform.position.x > 100f|| 
        bullet.transform.position.x < -100f) {
            Destroy(bullet);
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player")) {
            playerHealthScript.playerHealth -= 20;
            Destroy(bullet);
        }

        if (collision.gameObject.CompareTag("bullet")) {
            bulletHealth -= 10;
            Destroy(collision.gameObject);
        }
    }
}
