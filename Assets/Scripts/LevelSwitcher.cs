using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSwitcher : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] private string LevelName;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

        public void switchLevel()
    {
        Debug.Log("Level Entered: " + LevelName);
        SceneManager.LoadScene(LevelName);
        
    }
}
