using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    
   
    public Ball ball;
    public float player_Score=0, computer_Score=0;
    public Text playerScorTxet,computerScorTxet;


    private void Update()
    {

    }
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
