using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchingArea : MonoBehaviour
{
    public GameObject ram;
    public GameObject ball;
    public float maximumForce = 200;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject == ram)
        {
            Debug.Log(Vector3.forward * maximumForce * ram.GetComponent<Ram>().releaseT);
            ball.GetComponent<Rigidbody>().AddForce(Vector3.forward * maximumForce * ram.GetComponent<Ram>().releaseT);
            ram.GetComponent<Ram>().releaseT = 0;
        }
    }
}
