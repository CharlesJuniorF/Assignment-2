using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int winningScore;
    public TMP_Text player1Text;
    public TMP_Text player2Text;

    private static int player1Score;
    private static int player2Score;

    // Start is called before the first frame update
    void Start()
    {
        player1Score = 0;
        player2Score = 0;

    }

    // Update is called once per frame
    void Update()
    {
        player1Text.text = player1Score.ToString();
        player2Text.text = player2Score.ToString();
    }

    public static void addScore(int Player) 
    { 
        if (Player == 1)
        {
            player1Score++;
        }
        else
        {
            player2Score++;
        }

    }
}
