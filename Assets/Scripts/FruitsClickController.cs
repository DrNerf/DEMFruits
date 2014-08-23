using UnityEngine;
using System.Collections;

public class FruitsClickController : MonoBehaviour
{
    private PlayerData Data;
    private bool AlreadyLost = false;

    void Start()
    {
        Data = Camera.main.GetComponent<PlayerData>();
        Destroy(gameObject, 4);
    }

    void OnMouseDown()
    {
        Data.Score += 1;
        GameObject.Destroy(gameObject);
        GameObject.Find("CoinSound").GetComponent<AudioSource>().Play();
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Player" && !AlreadyLost)
        {
            Data.Lost += 1;
            AlreadyLost = true;
        }
    }
}
