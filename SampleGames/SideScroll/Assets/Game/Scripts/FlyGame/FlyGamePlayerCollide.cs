using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyGamePlayerCollide : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Obstacle"))
        {
            FlyGameManager.Instance.GameOver();

            transform.SendMessage("Dead", SendMessageOptions.DontRequireReceiver);
        }
    }
}