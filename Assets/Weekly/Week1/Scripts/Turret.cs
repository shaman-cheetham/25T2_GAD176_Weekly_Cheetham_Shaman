using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{
    //We want to rotate while holding q and e

    void Update()
    {
       if(Input.GetKey(KeyCode.Q)) 
        {
            //Rotate LEFT
            transform.Rotate(0, 1, 0);
        }
        if (Input.GetKey(KeyCode.E))
        {
            //Rotate RIGHT
            transform.Rotate(0, -1, 0);
        }
    }
}
