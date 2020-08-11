using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardController : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            gameObject.transform.position -= transform.right * 0.3f;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            gameObject.transform.position += transform.right * 0.3f;
        }
    }
}
