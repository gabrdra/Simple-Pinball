using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathArea : MonoBehaviour
{
    public GameObject GameManager;
    public GameObject ball;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == ball.name)
        {
            GameManager.GetComponent<GameManager>().Death();
        }
    }
}
