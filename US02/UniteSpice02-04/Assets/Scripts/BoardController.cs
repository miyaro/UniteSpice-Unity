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
            gameObject.transform.position += transform.right * 0.3f;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            gameObject.transform.position -= transform.right * 0.3f;
        }
    }

    private void LateUpdate()
    {
        if (transform.position.x >= 12.5f)
        {
            transform.position = new Vector3(12.5f, transform.position.y, transform.position.z);
        }
        else if (transform.position.x <= -12.5f)
        {
            transform.position = new Vector3(-12.5f, transform.position.y, transform.position.z);
        }
    }
}
