using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeInit : MonoBehaviour
{
    public GameObject boxPrefab;
    public GameObject boxesObj;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 5; i++)
        {
            GameObject box = Instantiate(boxPrefab, boxesObj.transform);
            box.transform.position = new Vector3(i*1.5f, 0f, 0f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
