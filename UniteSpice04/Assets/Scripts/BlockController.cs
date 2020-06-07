using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BlockController : MonoBehaviour
{
    public GameObject blockResource;
    public Transform blockParent;

    //ブロック並べる個数を決める
    public static int blockX = 11;
    public static int blockY = 5;

    //ブロックの合計数を持っておく
    public static int blockNum = blockX * blockY;

    private void Awake()
    {
        for (int x = 0; x < blockX; x++)
        {
            for (int y = 0; y < blockY; y++)
            {
                GameObject blocks = Instantiate(blockResource, blockParent);
                blocks.transform.position = new Vector3(-12.5f + 2.5f * x, 7.25f - 0.8f * y, 10);
            }
        }
    }
}