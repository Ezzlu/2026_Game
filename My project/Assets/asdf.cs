using UnityEngine;
using UnityEngine.SceneManagement;

public class asdf : MonoBehaviour
{
    public void go()
    {
        SceneManager.LoadScene("PlayScene_Door2");
    }


    public void ExitGame()
    {
        Application.Quit();
    }
}