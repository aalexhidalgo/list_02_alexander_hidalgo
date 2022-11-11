using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Exercise_2 : MonoBehaviour
{
    public float timeCounter; //Current Time: We introduce the SECONDS manually, through the inspector
    public float initialTime; //Start time

    public TextMeshProUGUI timeText;
    public Image timeImage;

    private bool canClick = true;

    void Update()
    {
        //The time will be going down the moment we press the start button
        if(timeCounter > 0 && canClick == false)
        {
            UpdateTime();
        }
    }

    public void UpdateTime()
    {
        timeCounter -= Time.deltaTime;
        timeText.text = Mathf.Round(timeCounter).ToString(); //With Mathf.Round we get the number without the miliseconds        
        timeImage.fillAmount = timeCounter / initialTime; //The amount of image will be shown by the amount of time that had passed to the start time
    }

    //To start the counting
    public void StartButton()
    {
        initialTime = timeCounter;      
        timeText.text = timeCounter.ToString();
        canClick = false;
    }
}
