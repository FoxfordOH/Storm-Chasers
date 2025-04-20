using UnityEngine;

public class WallBulletDelete : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("bullet"))
        {

            Bullet B = collision.GetComponent<Bullet>();

            if (B != null)
            {
                Destroy(collision.gameObject);
            }
        }
    }
}
