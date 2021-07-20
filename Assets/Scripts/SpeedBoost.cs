using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBoost : MonoBehaviour
{
    public GameObject ball;
    public float boostForce = 300;
    public Vector3 directionOfBoost = Vector3.forward;
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == ball.name)
        {
            collision.gameObject.GetComponent<Rigidbody>().AddForce(directionOfBoost * boostForce);
        }
    }
}
