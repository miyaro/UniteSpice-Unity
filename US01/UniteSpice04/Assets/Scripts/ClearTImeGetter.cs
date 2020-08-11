using UnityEngine;
using UnityEngine.UI;

public class ClearTImeGetter : MonoBehaviour
{
    Text clearTime;
    // Start is called before the first frame update
    void Start()
    {
        clearTime = this.GetComponent<Text>();
        clearTime.text = ("clear time: " + Mathf.Ceil(TimeManager.clearTime).ToString() + "秒");
    }
}
