using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gameManager1 : MonoBehaviour
{

    bool isGameOver = false;
    public float restartDelay = 2f;
    // Start is called before the first frame update
    public GameObject levelCom;

    public void LevelComplete()
    {
        Debug.Log("Level Completed");
        levelCom.SetActive(true);
    }

    public void GameOver()
    {
        if (isGameOver == false)
        {
            isGameOver = true;
            Debug.Log("game over");
            //Restart();
            Invoke("Restart", restartDelay);
        }

    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
