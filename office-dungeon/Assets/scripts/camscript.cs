using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camscript : MonoBehaviour
{
    public Transform playerpos;
  

 

    // Update is called once per frame

    void Update()
    {

        transform.position=playerpos.position;
        transform.rotation=playerpos.rotation;
        

    }
}
