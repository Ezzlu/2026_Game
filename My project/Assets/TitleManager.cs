using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleManager : MonoBehaviour
{
    public void good_bye()
    {
        SceneManager.LoadScene("TitleScene");
    }
}
