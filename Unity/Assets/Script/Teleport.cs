using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    Vector3 destination;
    void OnCollisionEnter(Collision coll)
    {
        if(this.name == "P1"){
            destination = GameObject.Find("P2").transform.position;
            coll.transform.position = destination - Vector3.forward * 5;
            coll.transform.Rotate(Vector3.up * 90);
        }
        else if ((this.name == "P2"))
        {
            destination = GameObject.Find("P1").transform.position;
            coll.transform.position = destination - Vector3.forward * 5;
            coll.transform.Rotate(Vector3.down * -90);
        }

    }
}
