using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{
    public float startTime = 200f;

    public static float clearTime;

    Text displayTime;

    // Update is called once per frame
    void Update()
    {
        displayTime = GetComponent<Text>();

        startTime -= Time.deltaTime;

        displayTime.text = Mathf.Ceil(startTime).ToString();

        clearTime += Time.deltaTime;

        if (startTime <= 0)
        {
            GameManager.LoadGameOver();
        }
    }
}
