using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonMenuScipt : MonoBehaviour
{

    public GameObject[] Scenes;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {

    }

    public void Gameoptions()
    {
        Scenes[0].SetActive(false);
        Scenes[1].SetActive(true);
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void MainMenu()
    {
        Scenes[0].SetActive(true);
        Scenes[1].SetActive(false);
    }

}
