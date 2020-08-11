using UnityEngine;

public class BlockController : MonoBehaviour
{
	/// <summary>
	/// ボールがブロックにぶつかった時、ボールコントローラーからこの関数が呼ばれて
	/// 該当ブロックが破壊される
	/// </summary>
	public void DestroyBlock()
    {
        Destroy(gameObject);
    }
}
