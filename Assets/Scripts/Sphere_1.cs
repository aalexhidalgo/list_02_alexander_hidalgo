using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere_1 : MonoBehaviour
{
    private Exercise_1 Exercise_1_Script;

    void Start()
    {
        Exercise_1_Script = FindObjectOfType<Exercise_1>();
    }

    private void OnMouseDown()
    {
        //We subtract one from the current enemy counter before destroying the sphere
        Exercise_1_Script.actualEnemies--;
        Destroy(gameObject);
    }
}
