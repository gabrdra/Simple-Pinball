using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Repel : MonoBehaviour
{
    public GameObject ball;
    public float forceOnImpact = 100;
    public Stats stats;
    public int score = 50;
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == ball.name)
        {
            stats.score += score;
            StartCoroutine(Expand(collision.gameObject.GetComponent<Rigidbody>(), collision.contacts[0].normal));
        }
    }
    IEnumerator Expand(Rigidbody b, Vector3 normal)
    {
        transform.localScale = new Vector3(1.2f, 1, 1.2f);
        b.GetComponent<Rigidbody>().AddForce(-normal*forceOnImpact);
        yield return new WaitForSeconds(0.5f);
        transform.localScale = Vector3.one;
    }
}
