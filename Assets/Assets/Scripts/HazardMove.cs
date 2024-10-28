using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HazardMove : MonoBehaviour
{
    public bool MoveUp = true;
    // Update is called once per frame
    void Update()
    {
       if(MoveUp == true) {

            transform.position -= new Vector3(0, 5, 0) * Time.deltaTime;
        }
        else
        {
            transform.position += new Vector3(0, 5, 0) * Time.deltaTime;

        }
       if(transform.position.y >= 7)
        {
            MoveUp = true;

        }
       if(transform.position.y <= -5)
        {
            MoveUp = false;

        }
    }
}
