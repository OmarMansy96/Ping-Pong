using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScript : MonoBehaviour
{
    public GameObject exitPanel;
    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            exitPanel.SetActive(true);
        }

    }
    public void ConfirmExit()
    {
        Application.Quit();
       
    }

    public void StartScene()
    {
        SceneManager.LoadScene("Start");
    }
    public void EasyScene()
    {
        SceneManager.LoadScene("Easy");
    }

    public void MediumScene()
    {
        SceneManager.LoadScene("Medium");
    }
    public void HardScene()
    {
        SceneManager.LoadScene("Hard");
    }
}
