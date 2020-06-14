using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStarter : MonoBehaviour
{
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
