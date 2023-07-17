using UnityEngine;
using UnityEngine.SceneManagement;

public class gameovermenuscript : MonoBehaviour
{

    public void RestartLevel()
    {
        
        SceneManager.LoadScene(FindObjectOfType<timerscript>().currentsceneindex);
    }

    public void exittomenu()
    {
        SceneManager.LoadScene("mainmenu");
    }
}
