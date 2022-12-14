using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise_3 : MonoBehaviour
{
    private float spaceLimits = 3.5f;

    private float distance = 1.75f; //Distance between squares
    private Vector3 nextPos;

    //Surprise
    public int pointsCounter;
    public GameObject winText;

    void Update()
    {
        //Teleport movement
        if (Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y != spaceLimits)
        {
            nextPos = new Vector3(transform.position.x, transform.position.y + distance, transform.position.z);
            transform.position = nextPos;
            transform.rotation = Quaternion.Euler(0, 0, -90);
        }

        if (Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y != -spaceLimits)
        {
            nextPos = new Vector3(transform.position.x, transform.position.y - distance, transform.position.z);
            transform.position = nextPos;
            transform.rotation = Quaternion.Euler(0, 0, -270);
        }

        if (Input.GetKeyDown(KeyCode.RightArrow) && transform.position.x != spaceLimits)
        {
            nextPos = new Vector3(transform.position.x + distance, transform.position.y, transform.position.z);
            transform.position = nextPos;
            transform.rotation = Quaternion.Euler(0, 0, -180);
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow) && transform.position.x != -spaceLimits)
        {
            nextPos = new Vector3(transform.position.x - distance, transform.position.y, transform.position.z);
            transform.position = nextPos;
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }

        if(pointsCounter == 12)
        {
            winText.SetActive(true);
        }
    }

    //Surprise: We make the pacman able to collect points
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Point"))
        {
            pointsCounter++;
            Destroy(other.gameObject);
        }
    }
}
