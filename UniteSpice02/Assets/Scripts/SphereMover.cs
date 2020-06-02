using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereMover : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Vector3 idou = new Vector3(2f, 0f, 2f);
        idou.x += 1f;
        idou.y += 1f;

        gameObject.transform.position = idou;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
