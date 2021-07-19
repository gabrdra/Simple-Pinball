using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleportation : MonoBehaviour
{
    public GameObject ball; // needs to be the instance of the ball and not its prefab.
    public GameObject teleporterArea1;
    public GameObject teleporterArea2;
    public Vector3 teleportationLocation1;
    public Vector3 teleportationLocation2;
    public bool inUse = false;
    public IEnumerator Teleport(GameObject originGameObject)
    {
        inUse = true;
        if (originGameObject == teleporterArea1)
        {
            ball.transform.position = teleportationLocation2;
        }
        else if(originGameObject == teleporterArea2)
        {
            ball.transform.position = teleportationLocation1;
        }
        yield return new WaitForSeconds(1);
        inUse = false;
    }
}
