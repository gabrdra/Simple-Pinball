using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportArea : MonoBehaviour
{
    public GameObject ball;
    public GameObject teleportation;
    private void OnTriggerEnter(Collider other)
    {
        if(other.name == ball.name && teleportation.GetComponent<Teleportation>().inUse == false)
        {
            StartCoroutine(teleportation.GetComponent<Teleportation>().Teleport(this.gameObject));
        }
    }
}
