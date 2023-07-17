using UnityEngine;

public class finishscript : MonoBehaviour
{
    public gamemanage g;
    void OnTriggerEnter()
    {
        g.completelevel();
    }

   
}
