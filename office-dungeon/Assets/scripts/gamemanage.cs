using UnityEngine;
using UnityEngine.SceneManagement;
public class gamemanage : MonoBehaviour
{
    bool gamehasended=false;
    public GameObject completelevelui;
    public GameObject timerui;
    public GameObject gameoverui;
    public playermovement p;
    public void completelevel()
    {
        completelevelui.SetActive(true);
        timerui.SetActive(false);
        p.enabled = false;
        
    }
    public void EndGame()
    {
        if (gamehasended == false)
        {
            gamehasended=true;
            gameoverui.SetActive(true);
            /*SceneManager.LoadScene("gameoverscene");*/
            /*Invoke("Restart", 2f);*/
        }
    }
    
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    
}
