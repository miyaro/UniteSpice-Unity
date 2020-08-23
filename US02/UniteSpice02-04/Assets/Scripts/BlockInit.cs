using UnityEngine;

public class BlockInit : MonoBehaviour
{
    //ブロックの元プレファブ
    public GameObject blockResource;

    //親オブジェクトの場所
    public Transform blockParent;

    //ブロックの横の数
    public static int blockX = 11;
    //ブロックの縦の数
    public static int blockY = 5;
    public static int blockNum = blockX * blockY;

    // Start is called before the first frame update
    void Start()
    {
        for (int x = 0; x < blockX; x++)
        {
            for (int y = 0; y < blockY; y++)
            {
                GameObject block = Instantiate(blockResource, blockParent);
                block.transform.position = new Vector3(-12.5f + 2.5f * x, 7.25f - 0.8f * y, 10);
            }
        }
    }

}
