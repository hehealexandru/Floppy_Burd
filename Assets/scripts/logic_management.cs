using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class logic_management : MonoBehaviour
{
    public int playerScore;
    public TextMeshProUGUI scoreText;
    public GameObject startText;
    public GameObject gameOverScreen;
    public GameObject pipeSpawner;
    public Button playAgainButton;
    public Button goMainMenuButton;
    public AudioSource Bit;
    public AudioSource ded;
    public TextMeshProUGUI tauntText;
    public bool gameStarted = false;

    void Start()
    {
        startText.SetActive(true);
        scoreText.gameObject.SetActive(false);
        pipeSpawner.gameObject.SetActive(false);
        Bit.gameObject.SetActive(false);
        ded.gameObject.SetActive(false);
        tauntText.gameObject.SetActive(false);
    }

    [ContextMenu("Increase Score")]
    public void addScore(int scoreToAdd)
    {
        if (!gameOverScreen.activeSelf)
        {
            playerScore = playerScore + scoreToAdd;
            scoreText.text = playerScore.ToString();
            Bit.gameObject.SetActive(true);
            Bit.Play();
            ShowTauntText();
        }
    }


    public void StartGame()
    {
        startText.SetActive(false);
        scoreText.gameObject.SetActive(true);
        gameStarted = true;
        pipeSpawner.gameObject.SetActive(true);
    }

    void ShowTauntText()
    {
        switch (playerScore)
        {
            case 5:
                {
                    tauntText.gameObject.SetActive(true);
                    tauntText.text = "Are you still here?";
                    break;
                }
            case 6:
                {
                    tauntText.text = "";
                    break;
                }

            case 10:
                {
                    tauntText.gameObject.SetActive(true);
                    tauntText.text = "You're bored, aren't you?";
                    break;
                }

            case 11:
                {
                    tauntText.text = "";
                    break;
                }

            case 15:
                {
                    tauntText.gameObject.SetActive(true);
                    tauntText.text = "Do you have a social life?";
                    break;
                }

            case 16:
                {
                    tauntText.text = "";
                    break;
                }

            case 20:
                {
                    tauntText.gameObject.SetActive(true);
                    tauntText.text = "Come on now, knock it off!";
                    break;
                }

            case 21:
                {
                    tauntText.text = "";
                    break;
                }

            case 25:
                {
                    tauntText.gameObject.SetActive(true);
                    tauntText.text = "STOP THIS AT ONCE!!";
                    break;
                }

            case 26:
                {
                    tauntText.text = "";
                    break;
                }

            case 30:
                {
                    tauntText.gameObject.SetActive(true);
                    tauntText.text = "I give up, do what you want.";
                    break;
                }

            case 31:
                {
                    tauntText.text = "";
                    break;
                }

            case 999:
                {
                    tauntText.gameObject.SetActive(true);
                    tauntText.text = "What did you achieve? Just a time lost and no one to celebrate you! Shame.";
                    break;
                }

            default:
                {
                    tauntText.gameObject.SetActive(false);
                    break;
                }
        }
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void goToMainMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);
        ded.gameObject.SetActive(true);
        ded.Play();
    }


}