using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverSceneChange : MonoBehaviour
{
    public void GameOver()
    {
        SceneManager.LoadScene("Feedback");
    }
}
