using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject restartScreen;
    bool gameHasEnded = false;

    public void GameOver()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;

            restartScreen.SetActive(true);           
        }

    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    void Update()
    {
        if (gameHasEnded==true && Input.GetButton("Jump")) 
        {
            Restart();
        }
    }
}
