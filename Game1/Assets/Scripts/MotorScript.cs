using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotorScript : MonoBehaviour
{
    HingeJoint2D hinge;

    public float force = 10;
    public float minAngle = 5;

    void Start()
    {
        hinge = GetComponent<HingeJoint2D>();
    }

    void FixedUpdate()
    {

        float targetForce = hinge.referenceAngle - hinge.jointAngle;
        targetForce = Mathf.Sign(targetForce) * Mathf.Max(0, Mathf.Abs(targetForce) - minAngle);

        Rigidbody2D.AddTorqueAtPosition(force * targetForce, transform.TransformPoint(hinge.anchor));
    }
}


// Update is called once per frame
void Update()
    {
        
    }
}
