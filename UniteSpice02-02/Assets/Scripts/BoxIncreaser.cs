using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxIncreaser : MonoBehaviour
{
    [SerializeField] GameObject boxPrefab;
    [SerializeField] GameObject boxesObj;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                GameObject box = Instantiate(boxPrefab, boxesObj.transform);
               　box.transform.position = new Vector3(i * 1.5f, j * 1.5f, 0f);
            }
        }
    }

// Update is called once per frame
void Update()
    {
        
    }
}
