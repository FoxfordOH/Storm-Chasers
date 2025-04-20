using UnityEngine;

public class Bullet : MonoBehaviour
{
    GameObject bullet;
    GameObject gunManager;
    [SerializeField] Enemy enemyRef;
    Rigidbody2D bulletRB;
    GameObject screenCenter;
    [SerializeField] float bulletSpeed = 20;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        bullet = this.gameObject;
        bulletRB = this.GetComponent<Rigidbody2D>();
        screenCenter = GameObject.FindGameObjectWithTag("screenCenter");
        gunManager = GameObject.FindGameObjectWithTag("gunSource");
    }

    // Update is called once per frame
    void Update()
    {
        bulletRB.transform.Translate(Vector2.left * bulletSpeed * Time.deltaTime);

// SET BOUNDS TO PLAYABLE AREA SIZE (If that's what we do)
        if (bullet.transform.position.y > 30f + screenCenter.transform.position.y || 
        bullet.transform.position.y < -30f + screenCenter.transform.position.y || 
        bullet.transform.position.x > 30f + screenCenter.transform.position.x || 
        bullet.transform.position.x < -30f + screenCenter.transform.position.x) {
            Destroy(bullet);
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy")) {
            Destroy(bullet);
        }
    }
}
