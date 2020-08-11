using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.transform.eulerAngles = new Vector3(0, 0, Random.Range(-45,45));
        gameObject.GetComponent<Rigidbody>().AddForce(transform.up * 500);
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Cube"))
        {
            other.transform.SendMessage("DestroyBlock", SendMessageOptions.DontRequireReceiver);

            BlockInit.blockNum--;
            Debug.Log(BlockInit.blockNum);

            if (BlockInit.blockNum <= 0)
            {
                SceneManager.LoadScene("GameClear");
            }
        }

        if (other.gameObject.CompareTag("Bottom"))
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
