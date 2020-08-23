using UnityEngine;
using UnityEngine.UI;

public class ClearTimeGetter : MonoBehaviour
{
    Text clearTime;
    // Start is called before the first frame update
    void Start()
    {
        clearTime = this.GetComponent<Text>();
        clearTime.text = ("Clear Time: " + Mathf.Ceil(TimeManager.clearTime).ToString() + "秒");
    }
}
