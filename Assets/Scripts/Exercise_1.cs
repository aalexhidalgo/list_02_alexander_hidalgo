using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise_1 : MonoBehaviour
{
    //Camera limits
    private float xLimit = 8.35f;
    private float yLimit = 4.35f;

    public GameObject spherePrefab;

    public int actualEnemies = 1;
    public int currentWave = 1;

    void Update()
    {
        if(actualEnemies == 0) //If we dont make disappear all of the enemies of the scene, we cannot start another wave
        {
            currentWave++;
            actualEnemies = currentWave; /*Very important, we update the enemy total with the current wave, 
            without this your PC can literally explode counting as long as it can last*/

            //Cycle: The number of enemies that will appear will be decided by the current wave
            for (int i = 0; i < currentWave; i++)
            {
                Instantiate(spherePrefab, RandomPos(), spherePrefab.transform.rotation);
            }
        }
    }

    //The sphere gets a random position between the camera limits
    private Vector3 RandomPos()
    {
        return new Vector3(Random.Range(-xLimit, xLimit), Random.Range(-yLimit, yLimit), 0);
    }
}
