using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockInit: MonoBehaviour
{
    // ブロックの元プレファブ
    public GameObject blockResource;
    // ゲーム上のブロックを格納する親オブジェクト
    public Transform blockParent;

    static int blockX = 11;
    static int blockY = 5;
    public static int blockNum = blockX * blockY;

    private void Awake()
    {
        // ブロックを初期化
        // １行に11個のブロックを設置
        for (var x = 0; x < blockX; x++)
        {
            // 指定行分ブロックを作成する
            for (var y = 0; y < blockY; y++)
            {
                // ブロックリソースからブロックを作成
                GameObject blocks = Instantiate(blockResource, blockParent);
                // ブロックの位置を指定
                blocks.transform.position = new Vector3(-12.5f + 2.5f * x, 7.25f - 0.8f * y, 10);
            }
        }
    }
}