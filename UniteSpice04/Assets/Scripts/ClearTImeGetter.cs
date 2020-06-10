using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClearTImeGetter : MonoBehaviour
{
    Text clearTime;
    // Start is called before the first frame update
    void Start()
    {
        clearTime = this.GetComponent<Text>();
        clearTime.text = ("clear time: " + Mathf.Ceil(BallController.clearTime).ToString() + "秒");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
