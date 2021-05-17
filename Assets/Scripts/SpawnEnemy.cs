using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    // The enemy prefab to be spawned
    private List<GameObject> listEnemy;
    public GameObject bug1;
    public GameObject bug2;
    public GameObject bug3;
    public GameObject bug4;
    public GameObject bug5;
    public GameObject bug6;
    // The boss
    private List<GameObject> listBoss;
    public GameObject boss1;
    public GameObject boss2;
    // The position of enemy to be spawned
    private Vector3 appearPosition;
    // The time for each enemy to be spawned
    private float appearDuration;
    // The duration to spawn boss
    private float timeSpawnBoss;
    // Start is called before the first frame update
    void Start()
    {
        appearDuration = Time.time;
        timeSpawnBoss = 0;
        listEnemy = new List<GameObject>()
        {
            bug1,
            bug2,
            bug3,
            bug4,
            bug5,
            bug6
        };
        listBoss = new List<GameObject>()
        {
            boss1,
            boss2
        };
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        timeSpawnBoss += Time.deltaTime;
        if (Time.time > appearDuration + Random.Range(Constant.MIN_TIME_SPAWN_ENEMY, Constant.MAX_POWER_ENERGY))
        {
            RandomEnemyPosition();
            if (timeSpawnBoss >= Constant.TIME_SPAWN_BOSS)
            {
                RandomBossPicker();
                timeSpawnBoss = 0;
                return;
            }
            RandomEnemyPicker();
            appearDuration = Time.time;
        }
    }

    void RandomEnemyPicker()
    {
        int choice = Random.Range(0, 5);
        switch (choice)
        {
            case 0:
                Instantiate(listEnemy[0], appearPosition, listEnemy[0].transform.rotation);
                break;
            case 1:
                Instantiate(listEnemy[1], appearPosition, listEnemy[1].transform.rotation);
                break;
            case 2:
                Instantiate(listEnemy[2], appearPosition, listEnemy[2].transform.rotation);
                break;
            case 3:
                Instantiate(listEnemy[3], appearPosition, listEnemy[3].transform.rotation);
                break;
            case 4:
                Instantiate(listEnemy[4], appearPosition, listEnemy[4].transform.rotation);
                break;
            case 5:
                Instantiate(listEnemy[5], appearPosition, listEnemy[5].transform.rotation);
                break;
        }
    }

    void RandomBossPicker()
    {
        int choice = Random.Range(0, 1);
        switch (choice)
        {
            case 0:
                Instantiate(listBoss[0], appearPosition, listBoss[0].transform.rotation);
                break;
            case 1:
                Instantiate(listBoss[1], appearPosition, listBoss[1].transform.rotation);
                break;
        }
    }

    void RandomEnemyPosition()
    {
        int choice = Random.Range(0, 3);
        switch (choice)
        {
            case 0:
                appearPosition = new Vector3(8 + 7, Random.Range(-7f, 7f) + 3, 1);
                break;
            case 1:
                appearPosition = new Vector3(-8 + 7, Random.Range(-7f, 7f) + 3, 1);
                break;
            case 2:
                appearPosition = new Vector3(Random.Range(-8f, 8f) + 7, -7 + 3, 1);
                break;
            case 3:
                appearPosition = new Vector3(Random.Range(-8f, 8f) + 7, 7 + 3, 1);
                break;
        }
    }
}


