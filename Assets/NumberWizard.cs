using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{

    int max = 1001;
    int min = 1;
    int guess = 500;

    // Start is called before the first frame update
    void Start()
    {
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
            Debug.Log("Lower was pressed");
            min = guess;
            guess = (max + min) / 2; 
            Debug.Log(guess);
        }

        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("Higher was pressed");
            max = guess;
            guess = (max + min) / 2;
            Debug.Log(guess);
        }

        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Enter was pressed");
            Debug.Log($"{guess} is right, You are correct!!!!");
        }
    }
}
