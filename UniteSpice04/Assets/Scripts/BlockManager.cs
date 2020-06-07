using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BlockManager : MonoBehaviour
{

    public void DestroyBlock()
    {
        //自分自身を破壊する
        Destroy(gameObject);

        //blockが破壊された時にブロック数を1減らす関数を呼び出す
        DecreaceBlockNum();
    }

    //<summary>
    //ブロック数を減少させる関数
    public void DecreaceBlockNum()
    {
        BlockController.blockNum--;

        //blockの数が0以下になった時クリアシーンに移動
        if (BlockController.blockNum <= 0)
        {
            GameMaster.MoveClear();
        }
    }
}
