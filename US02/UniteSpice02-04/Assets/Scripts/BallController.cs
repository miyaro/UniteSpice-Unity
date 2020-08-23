using UnityEngine;

public class BallController : MonoBehaviour
{
    AudioSource SoundEffect;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.transform.eulerAngles = new Vector3(0, 0, Random.Range(-45,45));
        gameObject.GetComponent<Rigidbody>().AddForce(transform.up * 500);

        SoundEffect = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Cube"))
        {
            other.transform.SendMessage("DestroyBlock", SendMessageOptions.DontRequireReceiver);

            SoundEffect.Play();

            BlockInit.blockNum--;

            if (BlockInit.blockNum <= 0)
            {
                GameManager.LoadGameClear();
            }
        }

        if (other.gameObject.CompareTag("Bottom"))
        {
            GameManager.LoadGameOver();
        }
    }
}
