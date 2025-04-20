using System.Collections;
using Unity.VisualScripting;
using UnityEditor.Build;
using UnityEngine;

public class TrailFade : MonoBehaviour
{
    public GameObject fireTrailRef;
    public bool canFade;
    public bool takeDamage;
    public SpriteRenderer fireTrailRenderer;
    public Color trailOpactity;
    public int alphaVal;
    public GameObject playerRef;
    public PlayerHealthManager playerScript;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        fireTrailRef = this.gameObject;
        canFade = true;
        takeDamage = true;
        fireTrailRenderer = fireTrailRef.GetComponent<SpriteRenderer>();
        trailOpactity = fireTrailRenderer.color;
        playerRef = GameObject.FindGameObjectWithTag("Player");
        playerScript = playerRef.GetComponent<PlayerHealthManager>();
        alphaVal = 255;
    }

    // Update is called once per frame
    void Update()
    {
        if (canFade)
        {
            StartCoroutine(FadeTrail());
        }

        if (alphaVal <= 0)
        {
            Destroy(fireTrailRef);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            playerScript.playerHealth -= 5;
            Destroy(fireTrailRef);
        }
    }

    public IEnumerator FadeTrail()
    {
        while (canFade)
        {
            trailOpactity = new Color(255, 255, 255, alphaVal);
            alphaVal -= 25;
            canFade = false;
        }
        yield return new WaitForSeconds(0.5f);
        canFade = true;
    }
}
