using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.eulerAngles.z < 60) { 
        if (Input.GetKey(KeyCode.R))
        {
            transform.Rotate(0, 0, 0.05f);
        }
        }
        if (transform.eulerAngles.z > 0)
        {
            if (Input.GetKey(KeyCode.Q))
            {
                transform.Rotate(0, 0, -0.05f);
            }
        }
    }
}
