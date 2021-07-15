using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lock : MonoBehaviour
{
    public GameObject barrier;
    public GameObject launchingArea;
    public GameObject ball;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject == ball)
        {
            barrier.SetActive(true);
            launchingArea.SetActive(false);
        }
    }
}
