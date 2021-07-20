using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBoost : MonoBehaviour
{
    public GameObject ball;
    public float boostForce = 300;
    public Vector3 directionOfBoost = Vector3.forward;
    public Stats stats;
    public int score = 100;
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == ball.name)
        {
            collision.gameObject.GetComponent<Rigidbody>().AddForce(directionOfBoost * boostForce);
            stats.score += score;
        }
    }
}
