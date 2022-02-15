using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateBeam : MonoBehaviour
{
    public Transform targetLeft;    // The object whose rotation we want to match.
    public Transform targetRight;   // The object whose rotation we want to match.
    float speed = 100;              // Angular speed in degrees per sec.

    private bool click = false;
    private bool isleft = true;
    private bool startPos = false;

    void Update() 
    {
        // The step size is equal to speed times frame time.
        var step = speed * Time.deltaTime;
        
        if (!startPos)
        {
            // Rotate the transform a step closer to the target's.
            transform.rotation = Quaternion.RotateTowards(transform.rotation, targetLeft.rotation, step);
            if(transform.rotation.eulerAngles.z > 17.9)
            {
                startPos = true;
            }
        }


        if (startPos == true  && click == true && isleft == true)
        { 
            transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRight.rotation, step);
            
            if (transform.rotation.eulerAngles.z < 342.1 && transform.rotation.eulerAngles.z > 341.9 ) //euler does not have a negative value, it is 360 - the value
            {
                click = false;
                isleft = false;
            }
        }

        else if (startPos && click == true && isleft == false)
        {
            transform.rotation = Quaternion.RotateTowards(transform.rotation, targetLeft.rotation, step);
            if (transform.rotation.eulerAngles.z > 17.9 && transform.rotation.eulerAngles.z < 18.1)
            {
                click = false;
                isleft = true;
            }
        }
    }

    void OnMouseDown()
    {
        click = true;
    }
}
