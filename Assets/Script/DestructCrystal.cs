using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestructCrystal : MonoBehaviour
{
    void Start()
    {
    }

    void Update()
    { 
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.collider.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
}
