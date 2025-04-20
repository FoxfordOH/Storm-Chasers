using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BossLevelManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private GameObject playerCamera = null;
    private Camera bossCamera = null;
    private bool BossBattleStarted = false;
    private bool InitialEnemiesSpawned = false;
    private bool BossBattleFinished = false;
    private bool BossSpawned = false;

    [SerializeField] private GameObject FireEnemyPrefab = null;
    [SerializeField] private GameObject WindEnemyPrefab = null;
    [SerializeField] private GameObject WaterEnemyPrefab = null;
    [SerializeField] private GameObject SnowEnemyPrefab = null;
    [SerializeField] private GameObject SunBossPrefab = null;
    [SerializeField] private GameObject WindBossPrefab = null;
    [SerializeField] private GameObject WaterBossPrefab = null;
    [SerializeField] private GameObject SnowBossPrefab = null;
    [SerializeField] private GameObject DoorRoomEnterPrefab = null;
    [SerializeField] private AudioClip SunBossMusic = null;
    [SerializeField] private AudioClip SnowBossMusic = null;
    [SerializeField] private AudioClip WindBossMusic = null;
    [SerializeField] private AudioClip WaterBossMusic = null;

    void Start()
    {
        playerCamera = GameObject.FindWithTag("MainCamera");
        bossCamera = GameObject.FindWithTag("BossCamera").GetComponent<Camera>();
        bossCamera.enabled = false;
        bossCamera.GetComponent<AudioListener>().enabled = false;
        StartCoroutine(LevelStart());
    }
    // Update is called once per frame

    void Update()
    {
        //Enemy Kill Check
        if (BossBattleStarted == false && InitialEnemiesSpawned == true)
        {
            enemyKillCheck();
        }

        if (BossBattleStarted == true && InitialEnemiesSpawned == true && BossBattleFinished == false && BossSpawned == true)
        {
            bossKillCheck();
        }
    }

    public IEnumerator LevelStart()
    {
        yield return new WaitForSeconds(5.0f);
        enemySpawn();
    }

    void enemySpawn()
    {
        if (SceneManager.GetActiveScene().name == "SunLevel")
        {
            Instantiate(FireEnemyPrefab, new Vector3(-14.01f, 4.85f, 0.0f), Quaternion.identity);
            Instantiate(FireEnemyPrefab, new Vector3(-11.26f, 4.33f, 0.0f), Quaternion.identity);

            Instantiate(FireEnemyPrefab, new Vector3(16.91f, 1.190001f, 0.0f), Quaternion.identity);
            Instantiate(FireEnemyPrefab, new Vector3(18.84f, -0.6999998f, 0.0f), Quaternion.identity);
            Instantiate(FireEnemyPrefab, new Vector3(19.82f, 1.33f, 0.0f), Quaternion.identity);

            Instantiate(FireEnemyPrefab, new Vector3(12.44f, 29.29f, 0.0f), Quaternion.identity);
            Instantiate(FireEnemyPrefab, new Vector3(11.21f, 30.52f, 0.0f), Quaternion.identity);

            Instantiate(FireEnemyPrefab, new Vector3(1.98f, 34.57f, 0.0f), Quaternion.identity);

            Debug.Log("Sun Level Enemies Spawned");
            InitialEnemiesSpawned = true;



        }
        else if (SceneManager.GetActiveScene().name == "WindLevel")
        {
            Instantiate(WindEnemyPrefab, new Vector3(-12.07f, 1.79f, 0.0f), Quaternion.identity);
            Instantiate(WindEnemyPrefab, new Vector3(-10.44f, 0.52f, 0.0f), Quaternion.identity);
            Instantiate(WindEnemyPrefab, new Vector3(-8.61f, 1.57f, 0.0f), Quaternion.identity);

            Instantiate(WindEnemyPrefab, new Vector3(14.83f, 3.34f, 0.0f), Quaternion.identity);
            Instantiate(WindEnemyPrefab, new Vector3(16.46f, 4.2f, 0.0f), Quaternion.identity);

            Instantiate(WindEnemyPrefab, new Vector3(-9.74f, 26.31f, 0.0f), Quaternion.identity);
            Instantiate(WindEnemyPrefab, new Vector3(-7.22f, 27.33f, 0.0f), Quaternion.identity);
            Instantiate(WindEnemyPrefab, new Vector3(-5.39f, 25.92f, 0.0f), Quaternion.identity);

            Instantiate(WindEnemyPrefab, new Vector3(8.58f, 32.17f, 0.0f), Quaternion.identity);
            Instantiate(WindEnemyPrefab, new Vector3(10.77f, 31.59f, 0.0f), Quaternion.identity);


            Debug.Log("Wind Level Enemies Spawned");
            InitialEnemiesSpawned = true;
        }
        else if (SceneManager.GetActiveScene().name == "WaterLevel")
        {
            Instantiate(WaterEnemyPrefab, new Vector3(-6.22f, 4.59f, 0.0f), Quaternion.identity);
            Instantiate(WaterEnemyPrefab, new Vector3(-4.24f, 5.14f, 0.0f), Quaternion.identity);

            Instantiate(WaterEnemyPrefab, new Vector3(12.84f, 7.76f, 0.0f), Quaternion.identity);
            Instantiate(WaterEnemyPrefab, new Vector3(13.72f, 6.04f, 0.0f), Quaternion.identity);

            Instantiate(WaterEnemyPrefab, new Vector3(14.44f, 30.85f, 0.0f), Quaternion.identity);
            Instantiate(WaterEnemyPrefab, new Vector3(16.19f, 30.47f, 0.0f), Quaternion.identity);

            Instantiate(WaterEnemyPrefab, new Vector3(-12.2f, 26.37f, 0.0f), Quaternion.identity);
            Instantiate(WaterEnemyPrefab, new Vector3(-10.25f, 25.38f, 0.0f), Quaternion.identity);
            Instantiate(WaterEnemyPrefab, new Vector3(-9.46f, 26.63f, 0.0f), Quaternion.identity);
            
            
            Debug.Log("Water Level Enemies Spawned");
            InitialEnemiesSpawned = true;
        }
        else if (SceneManager.GetActiveScene().name == "SnowLevel")
        {
            Instantiate(SnowEnemyPrefab, new Vector3(-8.72f, 4.77f, 0.0f), Quaternion.identity);
            Instantiate(SnowEnemyPrefab, new Vector3(-6.99f, 4.99f, 0.0f), Quaternion.identity);

            Instantiate(SnowEnemyPrefab, new Vector3(-16.48f, 20.53f, 0.0f), Quaternion.identity);
            Instantiate(SnowEnemyPrefab, new Vector3(-13.7f, 9.375117f, 0.0f), Quaternion.identity);

            Instantiate(SnowEnemyPrefab, new Vector3(16.21f, 30.05f, 0.0f), Quaternion.identity);
            Instantiate(SnowEnemyPrefab, new Vector3(16.94f, 28.59f, 0.0f), Quaternion.identity);
            Instantiate(SnowEnemyPrefab, new Vector3(18.22f, 29.83f, 0.0f), Quaternion.identity);

            Debug.Log("Snow Level Enemies Spawned");
            InitialEnemiesSpawned = true;

        }
    }

    void enemyKillCheck()
    {
        if (GameObject.FindGameObjectsWithTag("Enemy").Length == 0 && BossBattleStarted == false && InitialEnemiesSpawned == true)
        {
            Debug.Log("All Enemies Killed");
            StartCoroutine(BossBattleStart());
        }
    }

        void bossKillCheck()
    {
        if (GameObject.FindGameObjectsWithTag("Boss").Length == 0 && BossBattleFinished == false && InitialEnemiesSpawned == true && BossSpawned == true)
        {
            Debug.Log("Boss Killed");
            StartCoroutine(DoorRoomEnterSpawn());
        }
    }


    public IEnumerator BossBattleStart()
    {
        BossBattleStarted = true;
        yield return new WaitForSeconds(5.0f);
        Debug.Log("Boss Battle Started");
        BossSpawned = true;

        //Camera Switch
        playerCamera.SetActive(false);
        playerCamera.GetComponent<AudioListener>().enabled = false;
        bossCamera.enabled = true;
        bossCamera.GetComponent<AudioListener>().enabled = true;


        //Boss Spawn According To Level

        if (SceneManager.GetActiveScene().name == "SunLevel")
        {

            Instantiate(SunBossPrefab, new Vector3(1.19f, 19.9f, 0.0f), Quaternion.identity);
            Debug.Log("Sun Boss Spawned");
            AudioSource.PlayClipAtPoint(SunBossMusic, SunBossPrefab.transform.position);
        }
        else if (SceneManager.GetActiveScene().name == "WindLevel")
        {
            Instantiate(WindBossPrefab, new Vector3(1.42f, 19.16f, 0.0f), Quaternion.identity);
            Debug.Log("Wind Boss Spawned");
            AudioSource.PlayClipAtPoint(WindBossMusic, WindBossPrefab.transform.position);
        }
        else if (SceneManager.GetActiveScene().name == "WaterLevel")
        {
            Instantiate(WaterBossPrefab, new Vector3(1.36f, 18.01f, 0.0f), Quaternion.identity);
            Debug.Log("Water Boss Spawned");
            AudioSource.PlayClipAtPoint(WaterBossMusic, WaterBossPrefab.transform.position);
        }
        else if (SceneManager.GetActiveScene().name == "SnowLevel")
        {
            Instantiate(SnowBossPrefab, new Vector3(1.7f, 20.7f, 0.0f), Quaternion.identity);
            Debug.Log("Snow Boss Spawned");
            AudioSource.PlayClipAtPoint(SnowBossMusic, SnowBossPrefab.transform.position);
        }

    }

        public IEnumerator DoorRoomEnterSpawn()
    {
        BossBattleFinished = true;
        yield return new WaitForSeconds(5.0f);
        Debug.Log("Boss Battle Finished");


        //Boss Spawn According To Level
        
        if (SceneManager.GetActiveScene().name == "SunLevel")
        {

            Instantiate(DoorRoomEnterPrefab, new Vector3(1.48f, -1.95f, 0.0f), Quaternion.identity);
            Debug.Log("Door Spawned - Sun Level");
        }
        else if (SceneManager.GetActiveScene().name == "WindLevel")
        {
            Instantiate(DoorRoomEnterPrefab, new Vector3(1.156158f, -0.41f, 0.0f), Quaternion.identity);
            Debug.Log("Door Spawned - Sun Level");
        }
        else if (SceneManager.GetActiveScene().name == "WaterLevel")
        {
            Instantiate(DoorRoomEnterPrefab, new Vector3(1.37462f, 1.447012f, 0.0f), Quaternion.identity);
            Debug.Log("Door Spawned - Sun Level");
        }
        else if (SceneManager.GetActiveScene().name == "SnowLevel")
        {
            Instantiate(DoorRoomEnterPrefab, new Vector3(1.49f, 22.2f, 0.0f), Quaternion.identity);
            Debug.Log("Door Spawned - Sun Level");
        }

    }

}
