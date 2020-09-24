using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateLaunch : MonoBehaviour
{
    public HingeJoint HingeJointR = new HingeJoint();
    public HingeJoint HingeJointL = new HingeJoint();
    private 


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F))
        {
            HingeJointL.useMotor = true;
            HingeJointR.useMotor = true;
        }
    }
}
