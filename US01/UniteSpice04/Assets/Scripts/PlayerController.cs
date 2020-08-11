using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private const float moveLimit = 12.5f;

    private void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += transform.forward * 0.3f;
			transform.eulerAngles = new Vector3(0, 90, 0);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += transform.forward * 0.3f;
            transform.eulerAngles = new Vector3(0, -90, 0);
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