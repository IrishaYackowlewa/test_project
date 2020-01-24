using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateRoad : MonoBehaviour
{
    public int prob;
    public GameObject crystal;
    public GameObject roadElement; 
    private Vector3 lastPosition= new Vector3(5.854f, 0f, 1.761f);
    void Start()
    {
        InvokeRepeating("GenerateRoad", 1f, 0.3f);
    }

    void GenerateRoad()
    {
        int random = Random.Range(0, 2);
        if (random == 0)
        {
            NextRoadElement(1f, 0f, 0f);
            GenerateCrystal();
        }
        else
        {
            NextRoadElement(0f, 0f, 1f);
            GenerateCrystal();
        }
    }

    void GenerateCrystal()
    {
        int rand = Random.Range(0, 100);
        if (rand < prob)
        {
            GameObject nextCrystal = Instantiate(crystal) as GameObject;
            nextCrystal.transform.position = lastPosition + new Vector3(0f, 0.75f, 0f);
        }
    }

    void NextRoadElement(float x, float y, float z)
    {
        GameObject nextRoadElement = Instantiate(roadElement) as GameObject;
        nextRoadElement.transform.position = lastPosition + new Vector3(x, y, z);
        lastPosition = nextRoadElement.transform.position;
    }
    void Update()
    { 
    }
}
