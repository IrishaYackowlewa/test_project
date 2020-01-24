using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountCrystal : MonoBehaviour
{
    public Text word;
    private int count = 0;
    void Start()
    {
    }

    void Update()
    {
        word.text = "Crystal: " + count;
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.collider.tag == "Crystal")
        {
            count++;
        }
    }
}
