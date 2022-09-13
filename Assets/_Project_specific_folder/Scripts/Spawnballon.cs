using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Spawnballon : MonoBehaviour
{
    public List<Transform> mSpawnPoints;
    public List<GameObject> BalloonPrefabs;

    void Start()
    {
        StartCoroutine(StartSpawning());
    }
    IEnumerator StartSpawning()
    {
        yield return new WaitForSeconds(4f);
        var spawnpoint= mSpawnPoints.OrderBy(x => Random.value).ToList();
        //var shuffledListballon = BalloonPrefabs.OrderBy(x => Random.value).ToList();
        var shuffledList = BalloonPrefabs.OrderBy(x => Random.value).ToList();
        for (int i = 0; i < mSpawnPoints.Count; i++)
        {
            Instantiate(shuffledList[i], spawnpoint[i].position, Quaternion.identity);
        }
        StartCoroutine(StartSpawning());
    }
}
