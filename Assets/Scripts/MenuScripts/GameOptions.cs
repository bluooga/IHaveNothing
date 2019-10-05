using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameOptions : MonoBehaviour
{
    CameraScaler camscale;

    public Dropdown Resolution;
    public static int ScreenWidth;
    public static int ScreenHeight;


    private void Awake()
    {
        ScreenWidth = 1920;
        ScreenHeight = 1080;
    }

    // Start is called before the first frame update
    void Start()
    {
        camscale = Camera.main.GetComponent<CameraScaler>();
    }

    // Update is called once per frame
    void Update()
    {
        setResolution();
        Debug.Log(Resolution.value);
        Debug.Log(Camera.main.aspect);
    }

    public void setResolution()
    {
        if(Resolution.value == 0)
        {
            //1080p
            ScreenWidth = 1920;
            ScreenHeight = 1080;
            camscale.updateCamera();
        }else if (Resolution.value == 1)
        {
            //720p
            ScreenWidth = 1280;
            ScreenHeight = 720;
            camscale.updateCamera();
        }
        else if (Resolution.value == 2)
        {
            //800 x 600
            ScreenWidth = 800;
            ScreenHeight = 600;
            camscale.updateCamera();
        }
        else if (Resolution.value == 3)
        {
            //640 x 480
            ScreenWidth = 640;
            ScreenHeight = 480;
            camscale.updateCamera();
        }
    }




}
