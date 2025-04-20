using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class SunBossScript : MonoBehaviour
{
    GameObject sunBossVisual;
    GameObject sunBossRotate;
    [SerializeField] GameObject sunBeam0;
    [SerializeField] GameObject sunBeam1;
    [SerializeField] GameObject sunBeam2;
    [SerializeField] GameObject sunBeam3;
    [SerializeField] float rotateSpeed;
    [SerializeField] AudioSource sunAudioSource;
    [SerializeField] AudioClip sunPowerup;
    bool canRotate;
    bool canBlast = true;
    [SerializeField] Slider sunBossHealthBar;
    int sunHealth = 3000;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        sunBossVisual = GameObject.FindGameObjectWithTag("SunSprite");
        sunBossRotate = GameObject.FindGameObjectWithTag("SunRotate");
        sunBeam0.SetActive(false);
        sunBeam1.SetActive(false);
        sunBeam2.SetActive(false);
        sunBeam3.SetActive(false);
        sunAudioSource = sunBossVisual.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {   
        sunBossHealthBar.value = sunHealth;
        
        if (sunHealth <= 0) {
            Destroy(sunBossVisual);
        }

        if (canBlast) {
            StartCoroutine(SunAttack());
            canBlast = false;
        }

        if (canRotate) {
            sunBossRotate.transform.Rotate(Vector3.forward * rotateSpeed * Time.deltaTime);
        }
    }

    void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.CompareTag("bullet")) {
            sunHealth -= 20;
            Destroy(collision.gameObject);
        }
    }

    IEnumerator SunAttack() {
        sunAudioSource.PlayOneShot(sunPowerup);
        yield return new WaitForSeconds(1.5f);
        rotateSpeed = Random.Range(15, 26);
        canRotate = true;
        sunBeam0.SetActive(true);
        sunBeam1.SetActive(true);
        sunBeam2.SetActive(true);
        sunBeam3.SetActive(true);
        yield return new WaitForSeconds(6);
        canRotate = false;
        sunBeam0.SetActive(false);
        sunBeam1.SetActive(false);
        sunBeam2.SetActive(false);
        sunBeam3.SetActive(false);
        yield return new WaitForSeconds(4);
        canBlast = true;
    }
}
