using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Repel : MonoBehaviour
{
    public GameObject ball;
    private Rigidbody ballRigidbody;
    public float forceOnImpact = 100;
    private void Start()
    {
        ballRigidbody = ball.GetComponent<Rigidbody>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == ball.name)
        {
            StartCoroutine(Expand(collision.gameObject, collision.contacts[0].normal));
        }
    }
    IEnumerator Expand(GameObject b, Vector3 normal)
    {
        //Vector3 vector3 = new Vector3(-ball.transform.position.x * forceOnImpact, ball.transform.position.y, -ball.transform.position.z * forceOnImpact);
        transform.localScale = new Vector3(1.2f, 1, 1.2f);
        b.GetComponent<Rigidbody>().AddForce(normal*forceOnImpact);
        //ballRigidbody.velocity = Vector3.Reflect(ballRigidbody.velocity, normal);
        yield return new WaitForSeconds(0.5f);
        transform.localScale = Vector3.one;
    }
}
