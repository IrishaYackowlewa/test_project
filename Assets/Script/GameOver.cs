using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    void Start()
    {
    }
    void Update()
    {
        RaycastHit hit;
        if (!(Physics.Raycast(transform.position, Vector3.down, out hit, 5f) && hit.transform.gameObject.tag == "GameField"))
        {
            GetComponent<MoveBall>().enabled = false;
            Invoke("CallSc", 0.5f);
        }
    }
    void CallSc()
    {
        SceneManager.LoadScene("GameOver");
    }
}
