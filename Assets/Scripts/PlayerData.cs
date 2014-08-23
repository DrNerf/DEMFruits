using UnityEngine;
using System.Collections;

public class PlayerData : MonoBehaviour 
{
    public int Score = 0;
    public int Lost = 0;
    public Texture LostText;
    private bool Dead = false;

    void OnGUI()
    {
        GUI.Box(new Rect(Screen.width / 2 - (Screen.width - 50) / 2, -5, Screen.width - 50, 30), "Score : " + Score + " | Lost : " + Lost);
        if(GUI.Button(new Rect(3, Screen.height - 80,200, 60), "GO BACK"))
        {
            Application.LoadLevel(0);
        }
        if (Dead)
        {
            GUI.DrawTexture(new Rect(Screen.width / 2 - 209, Screen.height / 2 - 497 / 2, 418, 497), LostText);
        }
        
    }

    void Update()
    {
        if (Lost > 30)
        {
            if (!Dead)
            {
                Dead = true;
                Camera.main.GetComponent<AudioSource>().Stop();
                GameObject.Find("RektSound").GetComponent<AudioSource>().Play();
            }
        }
    }
}
