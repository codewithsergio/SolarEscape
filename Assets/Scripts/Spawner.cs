using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] obstaclePatterns;

    private float timeBtwSpawn;
    public float startTimeBetweenSpawn;
    public float decreaseTime;
    public float minTime;

    private void Update(){
        int rand = Random.Range(0, obstaclePatterns.Length);
        if(timeBtwSpawn <= 0){
            Instantiate(obstaclePatterns[rand], transform.position, Quaternion.identity); // Quaternion.identity means 0 rotation
            timeBtwSpawn = startTimeBetweenSpawn;
            if(startTimeBetweenSpawn > minTime){
                startTimeBetweenSpawn -= decreaseTime;
            }
        } else {
            timeBtwSpawn -= Time.deltaTime;
        }
    }
}
