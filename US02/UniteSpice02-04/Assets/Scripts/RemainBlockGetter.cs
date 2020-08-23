using UnityEngine;
using UnityEngine.UI;

public class RemainBlockGetter : MonoBehaviour
{
    Text RemainBlockNum;

    // Start is called before the first frame update
    void Start()
    {
        RemainBlockNum = GetComponent<Text>();
        RemainBlockNum.text = ("残りブロック数: " + BlockInit.blockNum.ToString());
    }
}
