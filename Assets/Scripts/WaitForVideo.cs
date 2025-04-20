using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WaitForVideo : MonoBehaviour
{
    bool loadLevel = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(WaitForVid());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator WaitForVid() {
        yield return new WaitForSeconds(16.5f);
        SceneManager.LoadScene(0);
    }
}
