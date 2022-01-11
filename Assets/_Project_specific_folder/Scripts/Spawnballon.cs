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
        //var shuffledList = mSpawnPoints.OrderBy(x => Random.value).ToList();
        //var shuffledListballon = BalloonPrefabs.OrderBy(x => Random.value).ToList();
        for (int i = 0; i < mSpawnPoints.Count; i++)
        {
            Instantiate(BalloonPrefabs[i], mSpawnPoints[i].position, Quaternion.identity);
        }
        StartCoroutine(StartSpawning());
    }
}
