using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScript : MonoBehaviour
{

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
