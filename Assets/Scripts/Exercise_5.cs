using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Exercise_5 : MonoBehaviour
{
    public TMP_InputField yearText;
    private int yearNumber;

    public Image animalImage;
    public Sprite[] animalSprite;
    private int animalYear;

    public TextMeshProUGUI AnimalText;
    public string[] animalTextArray;

    void Update()
    {
        if (yearText.text != "") // Only works filled up
        {
            animalImage.gameObject.SetActive(true);
            yearNumber = int.Parse(yearText.text); //This transfers the text received by the input field to an int
            animalYear = yearNumber % 12; //We show our animal year substracting to the year we were born (every 12 years is x animal)
            animalImage.sprite = animalSprite[animalYear];
            AnimalText.text = animalTextArray[animalYear]; //We show our animal year features
        }
    }
}
