using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Cube : MonoBehaviour
{
    public event Action OnDeath;
    private float passedPath = 0;

    private int speed;
    private int distance;
    private Vector3 endPosition;

    private void Update()
    {
        Move();
    }

    public void Init(int speed, int dictance)
    {
        this.speed = speed;
        this.distance = dictance;

        var randomVector = new Vector3(Random.Range(-100,100), 0, Random.Range(-100, 100));
        var direction = randomVector.normalized;
        endPosition = transform.position + direction * distance;
    }
    private void Move()
    {
        var step = speed * Time.deltaTime;
        passedPath += step;

        if (passedPath >= distance)
        {
            Death();
        }
        transform.position = Vector3.MoveTowards(transform.position, endPosition, step);
    }
    private void Death()
    {
         OnDeath?.Invoke();
        Destroy(gameObject);
    }
}
