using UnityEngine;
using UnityEngine.SceneManagement;
public class endlevelscript : MonoBehaviour
{
    public void movetonextlevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void mainmenu()
    {
        SceneManager.LoadScene("mainmenu");
    }
}
