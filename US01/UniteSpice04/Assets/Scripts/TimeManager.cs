using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{
	//ゲームの制限時間
    public float startTime = 300f;
	//クリア時間
    public static float clearTime;
    Text displayTime;

    // Update is called once per frame
    void Update()
    {
		//UIに残り時間を表示
        displayTime = GetComponent<Text>();
		//ゲームの制限時間から経過時間を引く
        startTime -= Time.deltaTime;
		//小数点を切り上げて文字列に変換してUIのテキストに表示
        displayTime.text = Mathf.Ceil(startTime).ToString();

        //クリアタイムを計算
        clearTime += Time.deltaTime;
        //残り時間が0になった時にゲームオーバーシーンに移動
        if (startTime <= 0)
        {
            GameMaster.MoveGameOver();
        }
    }
}