using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    bool GamehasEnded = false;

    public float restartDelay = 1f;

    public GameObject completeLevelUI; 

    public void  CompleteLevel()
    {

        completeLevelUI.SetActive(true);
    }
    
    public void EndGame()
    {
        if (GamehasEnded == false) 
        {

            GamehasEnded = true;
            Debug.Log("GAME OVER");
            Invoke("restart", restartDelay); 

        }
    }

    void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

