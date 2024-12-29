using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] float spawnTimeMin=1;
    [SerializeField] float spawnTimeMax=5;
    public GameObject[] carPreafabs;
    private void Start()
    {
        StartCoroutine(SpawnUpdate());
    }
    IEnumerator SpawnUpdate()
    {
        while (true) 
        {
            yield return new WaitForSeconds(Random.Range(spawnTimeMin, spawnTimeMax));
            Instantiate(carPreafabs[Random.Range(0, carPreafabs.Length)], transform.position, transform.rotation);
        }
    }

}
