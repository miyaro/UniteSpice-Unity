using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GmaeStarter : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //spaceボタンが押されたらGameシーンに移動する
        if(Input.GetKey(KeyCode.Space))
        {
            SceneManager.LoadScene("Game");
        }
    }
}
