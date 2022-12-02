using UnityEngine;

public class Spawnmanager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] animalPrefab;

    private float startSpwan = 2;
    private float intervalSpwan = 0.5f;

    private void Start()
    {
        InvokeRepeating("SpwanRandomAnimals", startSpwan, intervalSpwan);
    }

    private float randomX = -20;
    private float randomZ = 20;

    // Update is called once per frame
    private void Update()
    {// REMOVE BY INVOKE REPEAT
        /*  if (Input.GetKeyDown(KeyCode.S))
          {
              SpwanRandomAnimals();
          }
      }*/
    }

    private void SpwanRandomAnimals()
    {
        int animalIndex = Random.Range(0, animalPrefab.Length);
        Vector3 spwanLocation = new Vector3(Random.Range(randomX, randomZ), 0, randomZ);
        Instantiate(animalPrefab[animalIndex], spwanLocation, animalPrefab[animalIndex].transform.rotation);
    }
}
