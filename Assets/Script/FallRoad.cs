using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallRoad : MonoBehaviour
{
    void Start()
    {
    }

    void Update()
    {
    }
    void FallDown()
    {
        gameObject.GetComponent<Rigidbody>().useGravity = true;
        gameObject.GetComponent<Rigidbody>().isKinematic = false;
        Destroy(gameObject, 2.0f);
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.collider.tag == "Player")
        {
            Invoke("FallDown", 1.5f);
        }
    }

}
