using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScaler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Camera.main.aspect = 1920 / 1080;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void updateCamera()
    {
        Camera.main.aspect = GameOptions.ScreenWidth / GameOptions.ScreenHeight;
        Screen.SetResolution(GameOptions.ScreenWidth, GameOptions.ScreenHeight, false);
    }
}
