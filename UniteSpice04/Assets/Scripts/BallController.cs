using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallController : MonoBehaviour
{
    public static float clearTime;
    AudioSource SoundEffect;

    void Start()
    {
        // 角度-45~45間でランダム向きでボールに外部力をうつ。
        transform.eulerAngles = new Vector3(0, 0, Random.Range(-45, 45));
        gameObject.GetComponent<Rigidbody>().AddForce(transform.up * 500);
        SoundEffect = GetComponent<AudioSource>();
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
			//ブロック破壊用の関数を呼び出す
            other.transform.SendMessage("DestroyBlock", SendMessageOptions.DontRequireReceiver);

            //衝突時にSEが鳴るようにする
            SoundEffect.Play();

            //ブロックの初期数から一つ減らし、0になったらクリアにする
            BlockManager.boxNum--;
            if (BlockManager.boxNum <= 0)
            {
                loadResult();
            }
        }

        // 下のパネルにぶつかった場合GameOverシーンに移動する
        if (other.gameObject.CompareTag("Bottom"))
        {
            SceneManager.LoadScene("GameOver");
        }
    }

	private void Update()
	{
        clearTime += Time.deltaTime;
    }

	private void loadResult()
    {

        SceneManager.LoadScene("Clear");
    }
}