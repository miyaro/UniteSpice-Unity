using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{
    float startTime = 300f;
    Text displayTime;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        displayTime = this.GetComponent<Text>();
        startTime -= Time.deltaTime;
        displayTime.text = Mathf.Ceil(startTime).ToString();

        if(startTime <= 0)
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
