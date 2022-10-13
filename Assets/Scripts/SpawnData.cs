using UnityEngine;


[System.Serializable]

public class SpawnData
{
    [SerializeField] private int speed;
    [SerializeField] private int timeSpawn;
    [SerializeField] private int distance;
    public  int Speed=> speed;
    public  int TimeSpawn=> timeSpawn;
    public  int Distance=>distance;

    public SpawnData(int speed, int timeSpawn, int distance)
    {
        this.speed = speed;
        this.timeSpawn = timeSpawn;
        this.distance = distance;
    }
}
