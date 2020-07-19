using UnityEngine.SceneManagement;
using UnityEngine;

public class gameQuit : MonoBehaviour
{
  public void gameQuitFunction()
    {
        Application.Quit();
    }
  public void toMenu()
    {
        SceneManager.LoadScene("Menu");
    }

}
