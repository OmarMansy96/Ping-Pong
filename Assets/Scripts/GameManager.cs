using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    
   
    public Ball ball;
    public float player_Score=0, computer_Score=0, totalScore;
    public Text playerScorTxet,computerScorTxet,endMessage;
    public GameObject endPanel;
    bool pause=false;
    private void Start()
    {
        Time.timeScale = 1;
        endPanel.SetActive(false);
    }
    private void Update()
    {
        EndPanel();
        Pause();
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
    void EndPanel()
    {
        bool losing = computer_Score - player_Score >= 5;
        bool winnig = player_Score - computer_Score >= 5;
        if (winnig || losing)
        {
            Time.timeScale = 0;
            if (winnig)
            {
                endMessage.text = $"Game Over\nYou Win!\nScore:\n{totalScore}";
            }
            else if (losing)
            {
                endMessage.text = $"Game Over\nYou Lost!\nScore:\n{totalScore}";
            }
            endPanel.SetActive(true);
            ball.gameObject.SetActive(false);
        }

    }
    void Pause()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && pause == false)
        {
            pause = true;
            Time.timeScale = 0;
            endPanel.SetActive(true);
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && pause == true)
        {
            pause = false;
            Time.timeScale = 1;
            endPanel.SetActive(false);
        }
    }
    public void SanabbelLink()
    {
        Application.OpenURL("https://play.google.com/store/apps/dev?id=8621608341926800286");
    }


}
