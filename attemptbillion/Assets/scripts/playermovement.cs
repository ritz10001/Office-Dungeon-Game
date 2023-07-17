using UnityEngine;

public class playermovement : MonoBehaviour
{
    public float movespeed = 10f;
    public float rotatespeed = 120f;
   
    public Rigidbody rb;


    // Update is called once per frame
    void Update()
    {
        if(rb.position.y < -1f)
        {
            FindObjectOfType<gamemanage>().EndGame();
        }
        
        if (Input.GetKey("w"))
        {
            transform.Translate(new Vector3(0, 0, 1)*movespeed*Time.deltaTime);

        }
        else if (Input.GetKey("a"))
        {
            transform.Rotate(new Vector3(0, -1, 0)*rotatespeed*Time.deltaTime);

        }
        else if (Input.GetKey("s"))
        {
            transform.Translate(new Vector3(0, 0, -1)*movespeed*Time.deltaTime);

        }
        else if (Input.GetKey("d"))
        {
            transform.Rotate(new Vector3(0, 1, 0)*rotatespeed*Time.deltaTime);

        }
    }
}
