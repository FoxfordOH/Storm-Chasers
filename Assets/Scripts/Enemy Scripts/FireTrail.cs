using System.Collections;
using UnityEngine;

public class FireTrail : MonoBehaviour
{
    public GameObject trailRef;
    public GameObject fireEnemyRef;
    public bool canSpawnTrail;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        fireEnemyRef = this.gameObject;
        canSpawnTrail = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (canSpawnTrail)
        {
            StartCoroutine(SpawnTrail());
        }
    }

    public IEnumerator SpawnTrail()
    {
        while (canSpawnTrail)
        {
            Instantiate(trailRef, fireEnemyRef.transform.position, trailRef.transform.rotation);
            canSpawnTrail = false;
        }
        yield return new WaitForSeconds(0.5f);
        canSpawnTrail = true;
    }
}
