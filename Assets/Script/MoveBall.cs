using UnityEngine;

public class MoveBall : MonoBehaviour
{
    private Rigidbody rb;
    public float speed = 2f;
    private bool flag = true; 
    void Start()
    {
        rb = GetComponent<Rigidbody>(); 
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            flag = !flag;
        }
        if (flag)
        {
            rb.velocity = new Vector3(speed, 0f, 0f);
        }
        else
        {
            rb.velocity = new Vector3(0f, 0f, speed);
        }
    }
}