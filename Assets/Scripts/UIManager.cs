using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] private int SceneIndex;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void startClick()
    {
        Debug.Log("Start Clicked");
        SceneManager.LoadScene(6);
    }
    public void retryClick()
    {
        Debug.Log("Start Clicked");
        SceneManager.LoadScene(01);
    }
    public void quitClick()
    {
        Debug.Log("Quit Clicked");
        Application.Quit();
    }
    public void creditClick()
    {
        SceneManager.LoadScene(8);
    }
    public void menuClick()
    {
        SceneManager.LoadScene(0);
    }
}
