using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    MainMusic mus;
    public bool gameHasEnded = false;
    public float restartDelay = 2f;
    public GameObject CompleteLevelUI;
    public ScoreCounter score;
    public Text scoreText;
    public void EndGame()
    {
        if (!gameHasEnded)
        {
            score.enabled = false;
            scoreText.color = Color.cyan; 
            gameHasEnded = true;
            Invoke("Restart", restartDelay);
        }
    }

    public void EscapeFunction() {
        if (Input.GetKeyDown("escape"))
        {
            SceneManager.LoadScene("Menu");
        }
    }

    public void Restart()
    {
        gameHasEnded = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void CompleteLevel()
    {
        CompleteLevelUI.SetActive(true);
    }
    public void gameStart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void Update()
    {
        EscapeFunction();
    }
    public void Start()
    {
        GameObject.FindGameObjectWithTag("Music").GetComponent<MainMusic>().PlayMusic();
    }
}
