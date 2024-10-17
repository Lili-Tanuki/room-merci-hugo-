using JetBrains.Annotations;
using TMPro;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.Rendering;

public class GuessNumber : MonoBehaviour
{

    public TMP_Text messageText;
    public TMP_InputField numberInput;

    private int randomNumber;

    private void Start()
    {
        ResetGame();
    }

    public void Try()
    {
        if (string.IsNullOrWhiteSpace(numberInput.text) == true)
        {
            messageText.text = "That's not a valid number bitch. Try again";
            numberInput.text = "";
            return;
        }

        if (int.TryParse(numberInput.text, out int playerNumber))
        {
            if (playerNumber > randomNumber)
            {
                messageText.text = "Finally, thought you would never find it";
            }
            else if (playerNumber > randomNumber)
            {
                messageText.text = "Lower, you dumbass";
            }
            else if (playerNumber < randomNumber)
            {
                messageText.text = "Higher, what's taking you so long?";
            }
        }
        else
        {

            messageText.text = "That's not a valid number bitch. Try again";
            numberInput.text = "";
            return;

        }
        numberInput.text = "";
    }
    public void ResetGame()
    {
        messageText.text = "Guess the number";
        randomNumber = Random.Range(1, 100 + 1);
        Debug.Log("Generated number: " + randomNumber);
    }
}
