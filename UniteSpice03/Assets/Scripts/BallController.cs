using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallController : MonoBehaviour
{
    void Start()
    {
        // 角度-45~45間でランダム向きでボールに外部力をうつ。
        transform.eulerAngles = new Vector3(0, 0, 45);
        gameObject.GetComponent<Rigidbody>().AddForce(transform.up * -500);
    }

    // <summary>
    // ボールの当たり判定
    // </summary>
    // <param name = "other" ></ param >
    private void OnCollisionEnter(Collision other)
    {
        // ぶつかったものがブロックの場合は、ブロックの[DestroyBlock]関数を実行
        if (other.gameObject.CompareTag("Block"))
        {
            other.transform.SendMessage("DestroyBlock", SendMessageOptions.DontRequireReceiver);
        }

        // 下のパネルにぶつかった場合GameOverシーンに移動する
        if (other.gameObject.CompareTag("Bottom"))
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
