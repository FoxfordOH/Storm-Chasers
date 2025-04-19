using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    [SerializeField] Enemy enemyType;
    [SerializeField] GameObject selfRef;
    [SerializeField] int enemyHealth;
    void Start()
    {
        enemyHealth = enemyType.enemyHealth;
    }

    void Update()
    {
        if (enemyHealth <= 0) {
            Destroy(selfRef);
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("bullet")) {
            enemyHealth -= 10;
        }
    }
}
