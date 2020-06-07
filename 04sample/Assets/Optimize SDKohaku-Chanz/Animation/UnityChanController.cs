using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnityChanController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += transform.right * 0.1f;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position -= transform.right * 0.1f;
        }
    }
}
