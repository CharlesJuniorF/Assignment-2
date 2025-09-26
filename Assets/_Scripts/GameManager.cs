using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static int winningScore = 10;
    public TMP_Text player1Text;
    public TMP_Text player2Text;
    public TMP_Text winMessage;

    private static int player1Score;
    private static int player2Score;

    public static bool playing;

    // Start is called before the first frame update
    void Start()
    {
        winMessage.transform.parent.gameObject.SetActive(false);
        player1Score = 0;
        player2Score = 0;
        playing = true;
    }

    // Update is called once per frame
    void Update()
    {
        player1Text.text = player1Score.ToString();
        player2Text.text = player2Score.ToString();

        if (player1Score >= winningScore)
        {
            winMessage.text = "PLAYER 1\nWINS (:O";
            winMessage.transform.parent.gameObject.SetActive (true);
        }
        else if (player2Score >= winningScore)
        {
            winMessage.text = "PLAYER 2\nWINS (:O";
            winMessage.transform.parent.gameObject.SetActive(true);
        }
    }

    public static void addScore(int Player) 
    { 
        if (Player == 1)
        {
            player1Score++;
            if (player1Score == winningScore)
            {
                playing = false;
            }

        }
        else
        {
            player2Score++;
            if (player2Score == winningScore)
            {
                playing = false;
            }

        }

    }

    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
