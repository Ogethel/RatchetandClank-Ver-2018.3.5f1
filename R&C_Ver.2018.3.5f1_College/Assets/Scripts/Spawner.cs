using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] enemies;
    public Vector3 spawmValues;
    public float spawmWait;
    public float spawmMostWait;
    public float spawmLeastWait;
    public int startWait;
    public int enemiesSpawned = 0;
    //public int maxEnemies;
    public bool stop;

    int randEnemy;
    public float speed = 10;
    // Start is called before the first frame update
    void Start()
    {

        StartCoroutine(waitSpawmer());
    }

    // Update is called once per frame
    void Update()
    {
        spawmWait = Random.Range(spawmLeastWait, spawmMostWait);
        // transform.Translate(0, 0, -speed * Time.deltaTime);

        //if (maxEnemies <= enemiesSpawned)
        {
            //stop = true;
        }
        //else
        {
            //stop = false;
        }
  
    }
    IEnumerator waitSpawmer()
    {

        yield return new WaitForSeconds(startWait);

        while (!stop)
        {

            randEnemy = Random.Range(0, 2);

            Vector3 spawnPosition = new Vector3(Random.Range(-spawmValues.x, spawmValues.x), 1, Random.Range(-spawmValues.z, spawmValues.z));
            Instantiate(enemies[randEnemy], spawnPosition + transform.TransformPoint(0, 0, 0), gameObject.transform.rotation);

            yield return new WaitForSeconds(spawmWait);
        }
    }
}
