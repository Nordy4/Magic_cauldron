using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotionSpawner : MonoBehaviour
{
    public GameObject red;
    public GameObject blue;
    public GameObject green;
    public GameObject yellow;
    public GameObject purple;

    public List<Transform> potionSpawnPoints = new List<Transform>();

    // Start is called before the first frame update
    void Start()
    {
        spawnPotion();
    }

    private void spawnPotion(){
        //Red potion
        int randomSpawn = Random.Range(0, potionSpawnPoints.Count);
        Vector3 randomPosition = potionSpawnPoints[randomSpawn].position;
        GameObject potie1 = Instantiate(red, randomPosition, Quaternion.Euler(0,0,20));
        potionSpawnPoints.RemoveAt(randomSpawn);

        //Blue potion
        randomSpawn = Random.Range(0, potionSpawnPoints.Count);
        randomPosition = potionSpawnPoints[randomSpawn].position;
        GameObject potie2 = Instantiate(blue, randomPosition, Quaternion.Euler(0,40,20));
        potionSpawnPoints.RemoveAt(randomSpawn);

        //Green potion
        randomSpawn = Random.Range(0, potionSpawnPoints.Count);
        randomPosition = potionSpawnPoints[randomSpawn].position;
        GameObject potie3 = Instantiate(green, randomPosition, Quaternion.Euler(0,0,20));
        potionSpawnPoints.RemoveAt(randomSpawn);

        //Yellow potion
        randomSpawn = Random.Range(0, potionSpawnPoints.Count);
        randomPosition = potionSpawnPoints[randomSpawn].position;
        GameObject potie4 = Instantiate(yellow, randomPosition, Quaternion.Euler(0,0,45));
        potionSpawnPoints.RemoveAt(randomSpawn);

        //Purple potion
        randomSpawn = Random.Range(0, potionSpawnPoints.Count);
        randomPosition = potionSpawnPoints[randomSpawn].position;
        GameObject potie5 = Instantiate(purple, randomPosition, Quaternion.Euler(0,45,20));
        potionSpawnPoints.RemoveAt(randomSpawn);
    }
}
