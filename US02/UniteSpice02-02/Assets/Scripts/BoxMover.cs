﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxMover : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            gameObject.transform.position += gameObject.transform.right * 0.1f;
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            gameObject.transform.position -= gameObject.transform.right * 0.1f;
        }
    }
}
