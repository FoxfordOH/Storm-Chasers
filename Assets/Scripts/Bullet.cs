using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject bullet;
    public Rigidbody2D bulletRB;
    public GameObject screenCenter;
    private float bulletSpeed = 20;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        bulletRB = this.GetComponent<Rigidbody2D>();
        screenCenter = GameObject.FindGameObjectWithTag("screenCenter");
    }

    // Update is called once per frame
    void Update()
    {
        bulletRB.transform.Translate(Vector2.left * bulletSpeed * Time.deltaTime);

// SET BOUNDS TO PLAYABLE AREA SIZE
        if (bullet.transform.position.y > 7f + screenCenter.transform.position.y || 
        bullet.transform.position.y < -6f + screenCenter.transform.position.y || 
        bullet.transform.position.x > 10f + screenCenter.transform.position.x || 
        bullet.transform.position.x < -11f + screenCenter.transform.position.x) {
            Destroy(bullet);
        }
    }
}
