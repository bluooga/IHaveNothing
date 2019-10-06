using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangeScripts : MonoBehaviour
{

    public bool changeimmediately;

    // Start is called before the first frame update
    void Start()
    {
        if (changeimmediately)
        {
            LoadNextScene();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartThyGame()
    {
        SceneManager.LoadScene(2);
    }

    public void LoadNextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
