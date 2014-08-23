using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Spawner : MonoBehaviour 
{
    public List<GameObject> SpawPos = new List<GameObject>();
    public List<GameObject> Fruits = new List<GameObject>();
    void Start()
    {
        InvokeRepeating("Spawn", 0, 1);
    }

    void Spawn()
    {
        int RandomSpawn = Random.Range(0, 7);
        int RandomFruit = Random.Range(0, 2);
        GameObject.Instantiate(Fruits[RandomFruit], SpawPos[RandomSpawn].transform.position, Quaternion.identity);
    }
}
