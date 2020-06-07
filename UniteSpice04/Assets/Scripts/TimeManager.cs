using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{

    private Text remainingTime;
    public float time = 2f;
    //Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        remainingTime = GetComponent<Text>();
        time -= Time.deltaTime;
        remainingTime.text = Mathf.Ceil(time).ToString();

        if (time <= 0)
        {
            GameMaster.MoveGameOver();
        }
    }
}
