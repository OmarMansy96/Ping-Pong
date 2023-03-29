using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    public Ball ball;
    float player_Score, computer_Score;
    public Text playerScorTxet,computerScorTxet;


   
    public void PlayerPoint()
    {
        player_Score++;
        ball.ResetBall();
        playerScorTxet.text = player_Score.ToString();
    }
    public void ComputerPoint()
    {
        computer_Score++;
        ball.ResetBall();
        computerScorTxet.text = computer_Score.ToString();

    }
}
