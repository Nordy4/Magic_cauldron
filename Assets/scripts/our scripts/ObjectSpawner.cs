using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject red;
    public GameObject blue;
    public GameObject green;
    public GameObject yellow;
    public GameObject purple;

    public List<Transform> objectSpawnPoints = new List<Transform>();

    // Start is called before the first frame update
    void Start()
    {
        spawnObject();
    }

    private void spawnObject(){
        //Red potion
        int randomSpawn = Random.Range(0, objectSpawnPoints.Count);
        Vector3 randomPosition = objectSpawnPoints[randomSpawn].position;
        GameObject potie1 = Instantiate(red, randomPosition, Quaternion.Euler(-45,-90,0));
        objectSpawnPoints.RemoveAt(randomSpawn);

        //Blue potion
        randomSpawn = Random.Range(0, objectSpawnPoints.Count);
        randomPosition = objectSpawnPoints[randomSpawn].position;
        GameObject potie2 = Instantiate(blue, randomPosition, Quaternion.Euler(-90,180,0));
        objectSpawnPoints.RemoveAt(randomSpawn);

        //Green potion
        randomSpawn = Random.Range(0, objectSpawnPoints.Count);
        randomPosition = objectSpawnPoints[randomSpawn].position;
        GameObject potie3 = Instantiate(green, randomPosition, Quaternion.Euler(0,0,-45));
        objectSpawnPoints.RemoveAt(randomSpawn);

        //Yellow potion
        randomSpawn = Random.Range(0, objectSpawnPoints.Count);
        randomPosition = objectSpawnPoints[randomSpawn].position;
        GameObject potie4 = Instantiate(yellow, randomPosition, Quaternion.Euler(0,-90,0));
        objectSpawnPoints.RemoveAt(randomSpawn);

        //Purple potion
        randomSpawn = Random.Range(0, objectSpawnPoints.Count);
        randomPosition = objectSpawnPoints[randomSpawn].position;
        GameObject potie5 = Instantiate(purple, randomPosition, Quaternion.Euler(-90,0,0));
        objectSpawnPoints.RemoveAt(randomSpawn);
    }
}
