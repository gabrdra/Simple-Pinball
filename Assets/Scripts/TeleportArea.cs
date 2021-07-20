using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportArea : MonoBehaviour
{
    public GameObject ball;
    public GameObject teleportation;
    public Stats stats;
    public int score = 200;
    private void OnTriggerEnter(Collider other)
    {
        if(other.name == ball.name && teleportation.GetComponent<Teleportation>().inUse == false)
        {
            stats.score += score;
            StartCoroutine(teleportation.GetComponent<Teleportation>().Teleport(this.gameObject));
        }
    }
}
