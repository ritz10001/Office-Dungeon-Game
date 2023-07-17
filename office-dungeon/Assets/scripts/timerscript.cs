using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
public class timerscript : MonoBehaviour
{
    public float timeleft;
    public float originaltime;
    public TextMeshProUGUI timertext;
    public bool timerisrunning = false;
    public int currentsceneindex;
    // Start is called before the first frame update
    void Start()
    {
        timerisrunning = true;
        checkLevel();
    }

    // Update is called once per frame
    void Update()
    {
        if(timeleft > 0)
        {
            timeleft-= Time.deltaTime;
            if(timeleft>=0.25*originaltime && timeleft <= 0.5 * originaltime)
            {
                timertext.color = Color.yellow;
            }
            else if (timeleft >= 0.5 * originaltime)
            {
                timertext.color = Color.green;
            }
            else
            {
                timertext.color = Color.red;    
            }
            timertext.text = "TIME: "+timeleft.ToString("0");

        }
        else
        {
            timeleft = 0;
            timerisrunning = false;
            currentsceneindex = SceneManager.GetActiveScene().buildIndex;
            FindObjectOfType<gamemanage>().EndGame();
        }
    }

    void checkLevel()
    {

        if (SceneManager.GetActiveScene().buildIndex == 2)
        {
            timeleft = 45f;
            originaltime = timeleft;

        }

        else if (SceneManager.GetActiveScene().buildIndex == 3)
        {
            timeleft = 90f;
            originaltime = timeleft;

        }
        else if (SceneManager.GetActiveScene().buildIndex == 4)
        {
            timeleft = 120f;
            originaltime = timeleft;

        }





    }
}
