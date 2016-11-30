using UnityEngine;
using System.Collections;

public class CrossHair : MonoBehaviour
{

    public Texture crosshair;

    public int offsetw;
    public int offseth;
    public int divide = 1;


    void OnGUI()
    {
        GUI.DrawTexture(new Rect(Screen.width / 2 - offsetw, Screen.height / 2 - offseth, crosshair.width / divide, crosshair.height / divide), crosshair);
    }
}