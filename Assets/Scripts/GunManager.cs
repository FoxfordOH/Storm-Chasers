using UnityEngine;

public class GunManager : MonoBehaviour
{
	public GameObject bulletPrefab;
	public GameObject shootPoint;
	public int gunDamage;

	private Camera bossCamera = null;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gunDamage = 10;
		bossCamera = GameObject.FindWithTag("BossCamera").GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
		if (bossCamera == null  || bossCamera.enabled == false)
		{ {
		Vector2 playerPos = Camera.main.WorldToViewportPoint (transform.position);
		Vector2 mousePos = (Vector2)Camera.main.ScreenToViewportPoint(Input.mousePosition);
		float angle = PointToward(playerPos, mousePos);
		transform.rotation =  Quaternion.Euler (new Vector3(0f,0f,angle));

		if (Input.GetMouseButtonDown(0)) {
			Instantiate(bulletPrefab, shootPoint.transform.position, this.transform.rotation);
		}
		}
		}
		else
		{
		Vector2 playerPos = bossCamera.WorldToViewportPoint (transform.position);
		Vector2 mousePos = (Vector2)bossCamera.ScreenToViewportPoint(Input.mousePosition);
		float angle = PointToward(playerPos, mousePos);
		transform.rotation =  Quaternion.Euler (new Vector3(0f,0f,angle));

		if (Input.GetMouseButtonDown(0)) {
			Instantiate(bulletPrefab, shootPoint.transform.position, this.transform.rotation);
		}
		}
	}

	float PointToward(Vector3 a, Vector3 b) {
		return Mathf.Atan2(a.y - b.y, a.x - b.x) * Mathf.Rad2Deg;
	}
}

