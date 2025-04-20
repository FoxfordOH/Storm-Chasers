using System.Collections;
using UnityEngine;

public class SnowGunScript : MonoBehaviour
{
    GameObject snowBoss;
    public GameObject bulletPrefab;
    public GameObject shootPoint;
    public int gunDamage;
    public GameObject playerRef;
    public Vector3 playerPos;
    public bool canShoot = true;
    [SerializeField] AudioSource snowBossAudioSource;
    [SerializeField] AudioClip machineGun;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        snowBoss = GameObject.FindGameObjectWithTag("SnowBoss");
        gunDamage = 10;
        playerRef = GameObject.FindGameObjectWithTag("Player");
        snowBossAudioSource = snowBoss.GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        playerPos = playerRef.transform.position;
        float angle = PointToward(shootPoint.transform.position, playerPos);
        transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, angle));
        if (canShoot)
        {
            StartCoroutine(EnemyShootDelay());
        }

    }

    float PointToward(Vector3 a, Vector3 b)
    {
        return Mathf.Atan2(a.y - b.y, a.x - b.x) * Mathf.Rad2Deg;
    }

    private IEnumerator EnemyShootDelay()
    {
        bool nextShot = true;
        float shotDelay = 0.1f;
        snowBossAudioSource.PlayOneShot(machineGun);
        while (nextShot)
        {
            Instantiate(bulletPrefab, shootPoint.transform.position, this.transform.rotation);
            nextShot = false;
            canShoot = false;
        }
        yield return new WaitForSeconds(shotDelay);
        nextShot = true;
        while (nextShot)
        {
            Instantiate(bulletPrefab, shootPoint.transform.position, this.transform.rotation);
            nextShot = false;
        }
        yield return new WaitForSeconds(shotDelay);
        nextShot = true;
        while (nextShot)
        {
            Instantiate(bulletPrefab, shootPoint.transform.position, this.transform.rotation);
            nextShot = false;
        }
        yield return new WaitForSeconds(shotDelay);
        nextShot = true;
        while (nextShot)
        {
            Instantiate(bulletPrefab, shootPoint.transform.position, this.transform.rotation);
            nextShot = false;
        }
        yield return new WaitForSeconds(shotDelay);
        nextShot = true;
        while (nextShot)
        {
            Instantiate(bulletPrefab, shootPoint.transform.position, this.transform.rotation);
            nextShot = false;
        }
        yield return new WaitForSeconds(shotDelay);
        nextShot = true;
        while (nextShot)
        {
            Instantiate(bulletPrefab, shootPoint.transform.position, this.transform.rotation);
            nextShot = false;
        }
        yield return new WaitForSeconds(shotDelay);
        nextShot = true;
        while (nextShot)
        {
            Instantiate(bulletPrefab, shootPoint.transform.position, this.transform.rotation);
            nextShot = false;
        }
        yield return new WaitForSeconds(shotDelay);
        nextShot = true;
        while (nextShot)
        {
            Instantiate(bulletPrefab, shootPoint.transform.position, this.transform.rotation);
            nextShot = false;
        }
        yield return new WaitForSeconds(shotDelay);
        nextShot = true;
        while (nextShot)
        {
            Instantiate(bulletPrefab, shootPoint.transform.position, this.transform.rotation);
            nextShot = false;
        }
        yield return new WaitForSeconds(shotDelay);
        nextShot = true;
        while (nextShot)
        {
            Instantiate(bulletPrefab, shootPoint.transform.position, this.transform.rotation);
            nextShot = false;
        }
        yield return new WaitForSeconds(shotDelay);
        nextShot = true;
        while (nextShot)
        {
            Instantiate(bulletPrefab, shootPoint.transform.position, this.transform.rotation);
            nextShot = false;
        }
        yield return new WaitForSeconds(shotDelay);
        nextShot = true;
        while (nextShot)
        {
            Instantiate(bulletPrefab, shootPoint.transform.position, this.transform.rotation);
            nextShot = false;
        }
        yield return new WaitForSeconds(shotDelay);
        nextShot = true;
        while (nextShot)
        {
            Instantiate(bulletPrefab, shootPoint.transform.position, this.transform.rotation);
            nextShot = false;
        }
        yield return new WaitForSeconds(shotDelay);
        nextShot = true;
        while (nextShot)
        {
            Instantiate(bulletPrefab, shootPoint.transform.position, this.transform.rotation);
            nextShot = false;
        }
        yield return new WaitForSeconds(shotDelay);
        nextShot = true;
        while (nextShot)
        {
            Instantiate(bulletPrefab, shootPoint.transform.position, this.transform.rotation);
            nextShot = false;
        }
        yield return new WaitForSeconds(shotDelay);
        nextShot = true;
        while (nextShot)
        {
            Instantiate(bulletPrefab, shootPoint.transform.position, this.transform.rotation);
            nextShot = false;
        }
        yield return new WaitForSeconds(4);
        canShoot = true;
    }
}
