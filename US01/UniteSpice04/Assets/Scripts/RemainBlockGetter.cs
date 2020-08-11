using UnityEngine;
using UnityEngine.UI;

public class RemainBlockGetter : MonoBehaviour
{
    Text RemainBlock;

    void GetBlockNum()
    {
		RemainBlock = GetComponent<Text>();
        RemainBlock.text = ("残りブロック数: " + BlockInit.boxNum.ToString());
    }
    // Start is called before the first frame update
    void Start()
    {
        GetBlockNum();
    }
}
