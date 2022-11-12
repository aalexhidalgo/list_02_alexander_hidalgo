using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Exercise_4 : MonoBehaviour
{
    public TextMeshProUGUI turnText;
    private int currentTurn = 10;

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OptionButton()
    {
        currentTurn--;
        turnText.text = currentTurn.ToString();
    }
}
