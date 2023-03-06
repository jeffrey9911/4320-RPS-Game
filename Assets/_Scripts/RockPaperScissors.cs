using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RockPaperScissors : MonoBehaviour
{
    public GameObject Rock;
    public GameObject Paper;
    public GameObject Scissor;

    private GameObject AIChoiceObj;
    private GameObject PlayerChoiceObj;

    public RectTransform AIGen;
    public RectTransform PlayerGen;

    public TMP_Text GuiText;
    public TMP_Text MatchNumberText;

    private int playerChoice = 0;
    private int AIChoice = 0;

    private bool isGameStarted = false;

    private int MatchNumber = 0;

    private void Update()
    {
        if(isGameStarted)
        {
            AIChoice = Random.Range(1, 3);
            switch(AIChoice)
            {
                case 1:
                    Destroy(AIChoiceObj);
                    AIChoiceObj = Instantiate(Rock, AIGen);
                    AIChoiceObj.GetComponent<RectTransform>().localPosition = Vector3.zero;
                    break;

                case 2:
                    Destroy(AIChoiceObj);
                    AIChoiceObj = Instantiate(Paper, AIGen);
                    AIChoiceObj.GetComponent<RectTransform>().localPosition = Vector3.zero;
                    break;

                case 3:
                    Destroy(AIChoiceObj);
                    AIChoiceObj = Instantiate(Scissor, AIGen);
                    AIChoiceObj.GetComponent<RectTransform>().localPosition = Vector3.zero;
                    break;

                default:
                    break;
            }

            switch(playerChoice)
            {
                case 1:
                    if (AIChoice == 1) GuiText.text = "Even!";
                    if (AIChoice == 2) GuiText.text = "AI WINS!";
                    if (AIChoice == 3) GuiText.text = "YOU WIN!";
                    break;

                case 2:
                    if (AIChoice == 1) GuiText.text = "YOU WIN!";
                    if (AIChoice == 2) GuiText.text = "EVEN!";
                    if (AIChoice == 3) GuiText.text = "AI WINS!";
                    break;

                case 3:
                    if (AIChoice == 1) GuiText.text = "AI WINS!";
                    if (AIChoice == 2) GuiText.text = "YOU WIN!";
                    if (AIChoice == 3) GuiText.text = "EVEN!";
                    break;
            }

            MatchNumber++;
            MatchNumberText.text = "Total # of Match: " + MatchNumber;

            isGameStarted = false;

        }
    }

    public void ChooseRock()
    {
        Destroy(PlayerChoiceObj);
        playerChoice = 1;
        PlayerChoiceObj = Instantiate(Rock, PlayerGen);
        PlayerChoiceObj.GetComponent<RectTransform>().localPosition = Vector3.zero;
        isGameStarted = true;
    }

    public void ChoosePaper()
    {
        Destroy(PlayerChoiceObj);
        playerChoice = 2;
        PlayerChoiceObj = Instantiate(Paper, PlayerGen);
        PlayerChoiceObj.GetComponent<RectTransform>().localPosition = Vector3.zero;
        isGameStarted = true;
    }

    public void ChooseScissor()
    {
        Destroy(PlayerChoiceObj);
        playerChoice = 3;
        PlayerChoiceObj = Instantiate(Scissor, PlayerGen);
        PlayerChoiceObj.GetComponent<RectTransform>().localPosition = Vector3.zero;
        isGameStarted = true;
    }

}
