using UnityEngine;
using UnityEngine.SceneManagement;
public class menuscript : MonoBehaviour
{
    public void PlayButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+2);
    }

    

    public void Quit()
    {
        Application.Quit();
    }
    
}
