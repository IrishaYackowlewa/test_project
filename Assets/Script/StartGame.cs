using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartGame : MonoBehaviour
{
    public Text start;
    public Text count;
    public GameObject object1;
    void Start()
    {
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {

            GetComponent<MoveBall>().enabled = true;
            GetComponent<GameOver>().enabled = true;
            start.GetComponent<Text>().enabled = false;
            count.GetComponent<Text>().enabled = true;
            object1.GetComponent<CreateRoad>().enabled = true;
            GetComponent<StartGame>().enabled = false;
        }
    }
}
