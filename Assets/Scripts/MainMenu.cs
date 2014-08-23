using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour 
{
    void OnGUI()
    {
        if (GUI.Button(new Rect(Screen.width / 2 - 100, Screen.height / 2 - 30, 200, 60), "START"))
        {
            Application.LoadLevel(1);
        }

        if (GUI.Button(new Rect(Screen.width / 2 - 100, Screen.height / 2 + 35, 200, 60), "EXIT"))
        {
            Application.Quit();
        }
    }
	
}
