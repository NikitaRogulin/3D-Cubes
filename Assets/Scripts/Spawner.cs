using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Cube cubePrefab;

    private SpawnData actualData;
    private void Start()
    {
        StartCoroutine(CircleSpawn());
    }
    public void Setup(SpawnData data)
    {
        actualData = data;
    }

    private void Spawn()
    {
        var newCube = Instantiate(cubePrefab, transform.position, Quaternion.identity);
        newCube.Init(actualData.Speed, actualData.Distance);
    }

    private IEnumerator CircleSpawn()
    {
        while (true)
        {
            if (actualData != null)
            {
                Spawn();
                yield return new WaitForSeconds(actualData.TimeSpawn);
            }
            else
            {
                yield return new WaitForSeconds(1f);
            }
        }
    }
}
