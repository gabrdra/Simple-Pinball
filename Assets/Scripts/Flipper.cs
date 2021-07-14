using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flipper : MonoBehaviour
{
    public int springForce = 2500;
    public int damperForce = 0;
    public int finalPosition = 45;
    public int restingPosition = 0;
    public string inputKey = "d";
    HingeJoint hinge;
    JointSpring hingeSpring;
    void Start()
    {
        hinge = GetComponent<HingeJoint>();

        hingeSpring = hinge.spring;
        hingeSpring.spring = springForce;
        hingeSpring.damper = damperForce;
        hinge.spring = hingeSpring;
        hinge.useSpring = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(inputKey))
        {
            hingeSpring.targetPosition = finalPosition;
        }
        else
        {
            hingeSpring.targetPosition = restingPosition;
        }
        hinge.spring = hingeSpring;
    }
}
