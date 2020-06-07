using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallController : MonoBehaviour
{
    AudioSource soundEffect;

    // Start is called before the first frame update
    void Start()
    {
        transform.eulerAngles = new Vector3(0, 0, Random.Range(-45,45));
        gameObject.GetComponent<Rigidbody>().AddForce(transform.up * 500);

        soundEffect = GetComponent<AudioSource>();

    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Block"))
        {
            soundEffect.Play();
            other.transform.SendMessage("DestroyBlock", SendMessageOptions.DontRequireReceiver);
        }

        if (other.gameObject.CompareTag("Bottom"))
        {
            GameMaster.MoveGameOver();
        }
    }
}
