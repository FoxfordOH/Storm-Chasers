using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class WindBossScript : MonoBehaviour
{
    GameObject windBossRef;
    [SerializeField] AudioSource windAudioSource;
    [SerializeField] AudioClip windBurstClip;
    [SerializeField] bool canBurst = true;
    [SerializeField] Slider windHealthBar;
    int windHealth = 3000;
    float windLaunchForce;
    GameObject playerRef;
    Rigidbody2D playerRigidBody;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        windBossRef = GameObject.FindGameObjectWithTag("Wind Boss");
        windAudioSource = windBossRef.GetComponent<AudioSource>();
        playerRef = GameObject.FindGameObjectWithTag("Player");
        playerRigidBody = playerRef.GetComponent<Rigidbody2D>();
        canBurst = true;
    }

    // Update is called once per frame
    void Update()
    {
        windHealthBar.value = windHealth;

                if (windHealth <= 0) {
            Destroy(windBossRef);
        }

        if (canBurst)
        {
            StartCoroutine(WindAttack());
            canBurst = false;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("bullet"))
        {
            windHealth -= 20;
            Destroy(collision.gameObject);
        }
    }

    IEnumerator WindAttack()
    {
        windLaunchForce = 40f;
        int directionChoice = Random.Range(1, 5);
        windAudioSource.PlayOneShot(windBurstClip);
        if (directionChoice == 1)
        {
            playerRigidBody.AddForce(Vector2.right * windLaunchForce, ForceMode2D.Impulse);
        }
        else if (directionChoice == 2)
        {
            playerRigidBody.AddForce(Vector2.up * windLaunchForce, ForceMode2D.Impulse);
        }
        else if (directionChoice == 3)
        {
            playerRigidBody.AddForce(Vector2.down * windLaunchForce, ForceMode2D.Impulse);
        }
        else if (directionChoice == 4)
        {
            playerRigidBody.AddForce(Vector2.left * windLaunchForce, ForceMode2D.Impulse);
        }
        yield return new WaitForSeconds(6);
        canBurst = true;
    }
}
