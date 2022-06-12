using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawner2 : MonoBehaviour
{
    //GameObject [1] list = GameObject
    // Start is called before the first frame update
    public Vector2[] array = new Vector2[3];
    public int WaveTime = 40;
    public int SpawnDelay = 3;
    public GameObject EnemyOne;
    public bool CanSpawn = false;
    int wave = 0;
    int NumbersSpawned = 0;
    void Start()
    {
        //for (int i = 0; i < 3; i++){
        //    array[i] = new Vector2(i, i * 5 + 5);
        //}
        //Debug.Log(array);
        StartWave();
    }

    // Update is called once per frame
    void Update()
    {
        if (CanSpawn == true && NumbersSpawned < array [wave].y)
        {
            Instantiate(EnemyOne,transform);
            CanSpawn = false;
            NumbersSpawned++;
             if (NumbersSpawned >= array[wave].y)
            {
                wave++;
                Invoke("StartWave", WaveTime);
            }
                else
            {
                 Invoke("SpawnCoolDown", SpawnDelay);
            }
           

        }
        
    }
    void StartWave()
    {
        CanSpawn = true;
        NumbersSpawned = 0;
    }
    void SpawnCoolDown()
    {
        CanSpawn = true;
    }
}
