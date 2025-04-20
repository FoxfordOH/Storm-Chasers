using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHealthManager : MonoBehaviour
{
    public GameObject playerRef;
    public Slider playerHealthBar;
    public int playerHealth = 100;
    BoxCollider2D playerCollider;
    bool canBeHit;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerRef = this.gameObject;
        playerCollider = playerRef.GetComponent<BoxCollider2D>();
        playerHealth = 100;
        canBeHit = true;
    }

    // Update is called once per frame
    void Update()
    {
        playerHealthBar.value = playerHealth;

        if (playerHealth <= 0) {
        SceneManager.LoadScene(7);
        }        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy")) {
            canBeHit = false;
            Debug.Log("Hit by Enemy");
            playerHealth -= 5;
            StartCoroutine(PlayerIFrames()); 
        }

        if (collision.gameObject.CompareTag("SunSprite")) {
            playerHealth = 0;
        }
        
        if (collision.gameObject.CompareTag("SunBeam")) {
            Debug.Log("Hit by SunBeam");
            playerHealth -= 35;
        }

        if (collision.gameObject.CompareTag("Wind Boss")) {
            playerHealth -= 8;
        }

        if (collision.gameObject.CompareTag("WaterBoss")) {
            playerHealth -= 10;
        }

        if (collision.gameObject.CompareTag("SnowBoss")) {
            playerHealth -= 15;
        }

        if (collision.gameObject.CompareTag("SnowBullet")) {
        playerHealth -= 5;
        }


    }

    IEnumerator PlayerIFrames() {
        while (!canBeHit) {
            Physics2D.IgnoreLayerCollision(8, 3, true);
            Physics2D.IgnoreLayerCollision(8, 9, true);
            Physics2D.IgnoreLayerCollision(8, 10, true);
            Physics2D.IgnoreLayerCollision(8, 11, true);
            yield return new WaitForSeconds(2);
            Physics2D.IgnoreLayerCollision(8, 3, false);
            Physics2D.IgnoreLayerCollision(8, 9, false);
            Physics2D.IgnoreLayerCollision(8, 10, false);
            Physics2D.IgnoreLayerCollision(8, 11, false);
            canBeHit = true;
        }
    }
}
