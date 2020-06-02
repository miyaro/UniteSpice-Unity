using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockManager : MonoBehaviour
{
    // ブロックの元プレファブ
    public GameObject blockResource;
    // ゲーム上のブロックを格納する親オブジェクト
    public Transform blockParent;

    private void Awake()
    {
        // ブロックを初期化
        // １行に11個のブロックを設置
        for (var x = 0; x < 11; x++)
        {
            // 指定行分ブロックを作成する
            for (var y = 0; y < 5; y++)
            {
                // ブロックリソースからブロックを作成
                GameObject blocks = Instantiate(blockResource, blockParent);
                // ブロックの位置を指定
                blocks.transform.position = new Vector3(-12.5f + 2.5f * x, 7.25f - 0.8f * y, 10);
            }
        }
    }
}