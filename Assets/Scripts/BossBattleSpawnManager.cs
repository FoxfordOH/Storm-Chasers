using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class BossBattleSpawnManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private float spawntime = 0;
    private float spawnlocation = 0;
    [SerializeField] private GameObject FireEnemyPrefab = null;
    [SerializeField] private GameObject WindEnemyPrefab = null;
    [SerializeField] private GameObject WaterEnemyPrefab = null;
    [SerializeField] private GameObject SnowEnemyPrefab = null;
    private bool canSpawn = false;
    void Start()
    {
        StartCoroutine(SpawnEnemy());
        canSpawn = true;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (canSpawn == true && GameObject.FindGameObjectsWithTag("Enemy").Length <= 7)
        {
        StartCoroutine(SpawnEnemy());
        }
    }

    public IEnumerator SpawnEnemy()
    {
        canSpawn = false;
        
        if (SceneManager.GetActiveScene().name == "SunLevel")
        {spawntime = Random.Range(3f, 5f);
        }
        if (SceneManager.GetActiveScene().name == "WindLevel")
        {
            spawntime = Random.Range(3f, 5f);
        }
        if (SceneManager.GetActiveScene().name == "WaterLevel")
        {
            spawntime = Random.Range(3f, 5f);
        }
        if (SceneManager.GetActiveScene().name == "SnowLevel")
        {
            spawntime = Random.Range(3f, 5f);
        }
        
        yield return new WaitForSeconds(spawntime);

        if (SceneManager.GetActiveScene().name == "SunLevel")
        {
            spawnlocation = Random.Range(0, 4);
            if (spawnlocation == 0)
            {
                Instantiate(FireEnemyPrefab, new Vector3(-12.86f, 5.31f, 0.0f), Quaternion.identity);
                Debug.Log("Sun Enemy Spawned At: " + spawnlocation);
                canSpawn = true;
            }
            else if (spawnlocation == 1)
            {
                Instantiate(FireEnemyPrefab, new Vector3(18.93f, 1.61f, 0.0f), Quaternion.identity);
                Debug.Log("Sun Enemy Spawned At: " + spawnlocation);
                canSpawn = true;
            }
            else if (spawnlocation == 2)
            {
                Instantiate(FireEnemyPrefab, new Vector3(11.64f, 31.13f, 0.0f), Quaternion.identity);
                Debug.Log("Sun Enemy Spawned At: " + spawnlocation);
                canSpawn = true;
            }
            else
            {
                Instantiate(FireEnemyPrefab, new Vector3(1.27f, 34.93f, 0.0f), Quaternion.identity);
                Debug.Log("Sun Enemy Spawned At: " + spawnlocation);
                canSpawn = true;
            }

        }
        else if (SceneManager.GetActiveScene().name == "WindLevel")
        {
            spawnlocation = Random.Range(0, 4);
            if (spawnlocation == 0)
            {
                Instantiate(WindEnemyPrefab, new Vector3(-11.43431f, 1.78622f, 0.0f), Quaternion.identity);
                Debug.Log("Wind Enemy Spawned" + spawnlocation);
                canSpawn = true;
            }
            else if (spawnlocation == 1)
            {
                Instantiate(WindEnemyPrefab, new Vector3(15.29f, 4.29f, 0.0f), Quaternion.identity);
                Debug.Log("Wind Enemy Spawned" + spawnlocation);
                canSpawn = true;
            }
            else if (spawnlocation == 2)
            {
                Instantiate(WindEnemyPrefab, new Vector3(-7.68f, 27.49f, 0.0f), Quaternion.identity);
                Debug.Log("Wind Enemy Spawned" + spawnlocation);
                canSpawn = true;
            }
            else
            {
                Instantiate(WindEnemyPrefab, new Vector3(9.76f, 32.58f, 0.0f), Quaternion.identity);
                Debug.Log("Wind Enemy Spawned" + spawnlocation);
                canSpawn = true;
            }
        }
        else if (SceneManager.GetActiveScene().name == "WaterLevel")
        {
            spawnlocation = Random.Range(0, 4);
            if (spawnlocation == 0)
            {
                Instantiate(WaterEnemyPrefab, new Vector3(-5.52f, 5.52f, 0.0f), Quaternion.identity);
                Debug.Log("Water Enemy Spawned" + spawnlocation);
                canSpawn = true;
            }
            else if (spawnlocation == 1)
            {
                Instantiate(WaterEnemyPrefab, new Vector3(15.95f, 7.94f, 0.0f), Quaternion.identity);
                Debug.Log("Water Enemy Spawned" + spawnlocation);
                canSpawn = true;
            }
            else if (spawnlocation == 2)
            {
                Instantiate(WaterEnemyPrefab, new Vector3(-10.83f, 27.14f, 0.0f), Quaternion.identity);
                Debug.Log("Water Enemy Spawned" + spawnlocation);
                canSpawn = true;
            }
            else
            {
                Instantiate(WaterEnemyPrefab, new Vector3(16.08f, 31.07f, 0.0f), Quaternion.identity);
                Debug.Log("Water Enemy Spawned" + spawnlocation);
                canSpawn = true;
            }

        }
        else if (SceneManager.GetActiveScene().name == "SnowLevel")
        {
            spawnlocation = Random.Range(0, 4);
            if (spawnlocation == 0)
            {
                Instantiate(SnowEnemyPrefab, new Vector3(-7.37f, 5.2f, 0.0f), Quaternion.identity);
                Debug.Log("Snow Enemy Spawned" + spawnlocation);
                canSpawn = true;
            }
            else if (spawnlocation == 1)
            {
                Instantiate(SnowEnemyPrefab, new Vector3(-15f, 20.69f, 0.0f), Quaternion.identity);
                Debug.Log("Snow Enemy Spawned" + spawnlocation);
                canSpawn = true;
            }
            else if (spawnlocation == 2)
            {
                Instantiate(SnowEnemyPrefab, new Vector3(-4.94f, 34.82f, 0.0f), Quaternion.identity);
                Debug.Log("Snow Enemy Spawned" + spawnlocation);
                canSpawn = true;
            }
            else
            {
                Instantiate(SnowEnemyPrefab, new Vector3(16.88f, 30.9f, 0.0f), Quaternion.identity);
                Debug.Log("Snow Enemy Spawned" + spawnlocation);
                canSpawn = true;
            }
        }
    }
}