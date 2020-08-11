using UnityEngine;

public class BallController : MonoBehaviour
{
    AudioSource SoundEffect;

    void Start()
    {
        // 角度-45~45間でランダム向きでボールに外部力をうつ。
        transform.eulerAngles = new Vector3(0, 0, Random.Range(45, -45));
        gameObject.GetComponent<Rigidbody>().AddForce(transform.up * 500);

		//Audiosourceを取得
        SoundEffect = GetComponent<AudioSource>();
    }

    // <summary>
    // ボールの当たり判定
    // </summary>
    // <param name = "other" ></ param >
    private void OnCollisionEnter(Collision other)
    {
        // ぶつかったものがブロックの場合は、ブロックのDestroyBlock関数を実行
        if (other.gameObject.CompareTag("Block"))
        {
            //ブロック破壊用の関数を呼び出す
            other.transform.SendMessage("DestroyBlock", SendMessageOptions.DontRequireReceiver);
            //衝突時にSEが鳴るようにする
            SoundEffect.Play();

			//ブロック数を減らし、全て破壊したらゲームクリア
            BlockInit.boxNum--;

            if (BlockInit.boxNum <= 0)
            {
                GameMaster.MoveClear();
            }
        }

        // 下のパネルにぶつかった場合GameOverシーンに移動する
        if (other.gameObject.CompareTag("Bottom"))
        {
            GameMaster.MoveGameOver();
        }
    }
}