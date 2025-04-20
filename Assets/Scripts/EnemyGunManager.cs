using System.Collections;
using UnityEngine;

public class EnemyGunManager : MonoBehaviour
{
    public GameObject bulletPrefab;
    public GameObject shootPoint;
    public int gunDamage;
    public GameObject playerRef;
    public Vector3 playerPos;
    public bool canShoot = true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gunDamage = 10;
        playerRef = GameObject.FindGameObjectWithTag("Player");
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
        while (canShoot)
        {
            Instantiate(bulletPrefab, shootPoint.transform.position, this.transform.rotation);
            canShoot = false;
        }
        yield return new WaitForSeconds(2);
        canShoot = true;
    }
}
