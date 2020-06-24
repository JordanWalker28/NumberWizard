using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{

    int max = 1000;
    int min = 1;
    int guess = 500;
    int count = 0;

    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        RestartVariables();

        Debug.Log("Welcome to Number Wizard");
        Debug.Log("Pick a Number for the Wizard");
        Debug.Log($"The Highest Number you can pick is {max}, the Lowest you can pick is {min}");
        Debug.Log("Good Luck!");
        Debug.Log($"Tell me if your number is higher or lower than {guess}");
        Debug.Log("Push Up = Higher, Push Down = Lower");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            count++;
            min = guess;
            NextGuess();
        }

        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            count++;
            max = guess;
            NextGuess();
        }

        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log($"{guess} is right, I knew it all along!!!!");
            Debug.Log($"Just ignore the other {count - 1} guesses, I was just keeping you on your toes");
            StartGame();
        }
    }

    void NextGuess()
    {
        guess = (max + min) / 2;
        Debug.Log($"is it higher or lower than {guess}?");
    }

    void RestartVariables()
    {
        max = 1000;
        min = 1;
        guess = 500;
        count = 0;
    }
}
