using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardController : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position -= transform.right * 0.3f;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += transform.right * 0.3f;
        }
    }

}