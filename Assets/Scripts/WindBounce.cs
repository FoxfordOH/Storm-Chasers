using UnityEngine;

public class WindBounce : MonoBehaviour
{

    public GameObject playerRef;
    public Transform playerPos;
    public Rigidbody2D playerRB;
    public PlayerController playerScript;
    public float launchForce;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerRef = GameObject.FindGameObjectWithTag("Player");
        playerPos = playerRef.transform;
        playerRB = playerRef.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            launchForce = 18f;
            int directionChoice = Random.Range(1, 5);
            if (directionChoice == 1)
            {
                playerRB.AddForce(Vector2.right * launchForce, ForceMode2D.Impulse);
            }
            else if (directionChoice == 2)
            {
                playerRB.AddForce(Vector2.up * launchForce, ForceMode2D.Impulse);
            }
            else if (directionChoice == 3)
            {
                playerRB.AddForce(Vector2.down * launchForce, ForceMode2D.Impulse);
            }
            else if (directionChoice == 4)
            {
                playerRB.AddForce(Vector2.left * launchForce, ForceMode2D.Impulse);
            }
        }
    }
}
