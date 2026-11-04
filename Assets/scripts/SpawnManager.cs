using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // the [] brackets are arrays. 
 //arrays are variables that allow you to store multiple values under 1 name. great for saving space
    public GameObject[] animalPrefabs;
    
    float spawnRangeX = 20;
    float spawnPosZ = 20;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.S))
        {
            //randomly generates one of the animals index along with a random position.
            Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
            int animalIndex = Random.Range(0, animalPrefabs.Length);
            //instantiation is simply spawning in a game object.
            Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
        }   
    }
}
