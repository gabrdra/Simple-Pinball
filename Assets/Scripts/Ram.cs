using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ram : MonoBehaviour
{
    public float retractingSpeed = 0.8f;
    public float releaseSpeed = 2f;
    public GameObject initialPoint;
    public GameObject finalPoint;
    public Vector3 initialVectorPosition;
    public Vector3 finalVectorPosition;
    private float t = 0;
    public float releaseT;
    // Update is called once per frame
    void Start()
    {
        initialVectorPosition = initialPoint.transform.position;
        finalVectorPosition = finalPoint.transform.position;
    }
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space)){
            releaseT = t;
        }
        if (Input.GetKey(KeyCode.Space))
        {
            t = t + retractingSpeed * Time.deltaTime;
            if(t > 1)
            {
                t = 1;
            }
            
        }
        else{
            t = t - releaseSpeed * Time.deltaTime;
            if(t < 0)
            {
                t = 0;
            }
        }
        transform.position = Vector3.Lerp(initialVectorPosition, finalVectorPosition, t);
    }
}
