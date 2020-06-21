using UnityEngine;

public class PlayerCollide : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Obstacle"))
        {
            GameManager.Instance.GameOver();
            
            transform.SendMessage("Dead", SendMessageOptions.DontRequireReceiver);
        }
    }
}
