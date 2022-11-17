using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Exercise_4 : MonoBehaviour
{
    public TextMeshProUGUI turnText;
    private int currentTurn = 10;
    private int guessNumber; //Your guess for the turn

    //Random answer
    private int randomNumber;
    public GameObject[] randomGuess;

    private bool canClick = true; //To control when the player can click the options

    //Counters of correct and incorrect answers
    private int correctCounter;
    private int incorrectCounter;

    //Final stage
    public TextMeshProUGUI correctCounterText;
    public TextMeshProUGUI incorrectCounterText;
    public GameObject RestartButton;

    //Button function
    public void OptionButton(int number)
    {
        if(currentTurn > 0 && canClick)
        {
            randomGuess[randomNumber].SetActive(false);
            guessNumber = number; //First Option is 0 and Second Option is 1
            currentTurn--;
            turnText.text = currentTurn.ToString();
            StartCoroutine(RandomOption());
        }
    }

    //To randomize an answer
    private IEnumerator RandomOption()
    {
        canClick = false;
        randomNumber = Random.Range(0, 2); //The PC chooses between 0 and 1
        randomGuess[randomNumber].SetActive(true); //It shows the result on the screen

        //If we guess an answer, a point will be add to the correct answers counter
        if(randomNumber == guessNumber)
        {
            correctCounter++;
        }
        //If not a point will de add to the incorrect answers counter
        else
        {
            incorrectCounter++;
        }

        //If we play all the turns, the PC shows our results and we can play again
        if(currentTurn == 0)
        {
            yield return new WaitForSeconds(1f); //It shows the final answer before displaying the results
            randomGuess[randomNumber].SetActive(false);
            correctCounterText.gameObject.SetActive(true);
            incorrectCounterText.gameObject.SetActive(true);
            correctCounterText.text = $"You have guess {correctCounter} answers correctly";
            incorrectCounterText.text = $"You have guess {incorrectCounter} answers incorrectly";
            RestartButton.SetActive(true);
        }

        canClick = true;
    }

    //To restart the game
    public void RestartGame()
    {
        currentTurn = 10;
        turnText.text = currentTurn.ToString();
        correctCounterText.gameObject.SetActive(false);
        incorrectCounterText.gameObject.SetActive(false);
        canClick = true;
        RestartButton.SetActive(false);
    }
}
