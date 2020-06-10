using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardController : MonoBehaviour
{
    private const float moveLimit = 12.5f;

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

    private void LateUpdate()
    {
        if (transform.position.x >= moveLimit)
        {
            transform.position = new Vector3(moveLimit, transform.position.y, transform.position.z);
        }
        else if (transform.position.x <= -moveLimit)
        {
            transform.position = new Vector3(-moveLimit, transform.position.y, transform.position.z);
        }
    }
}