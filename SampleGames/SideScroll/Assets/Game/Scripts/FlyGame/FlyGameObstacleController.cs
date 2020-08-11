using UnityEngine;
using DG.Tweening;

public class FlyGameObstacleController : MonoBehaviour
{
    [SerializeField] private TrailRenderer line;

    public void Appear()
    {
        transform.position = new Vector3(0, Random.Range(-10, 10), 32);
        transform.gameObject.SetActive(true);
        line.gameObject.SetActive(true);
        MoveBall();
    }

    private void Disappear()
    {
        line.Clear();
        line.gameObject.SetActive(false);
        gameObject.SetActive(false);
    }

    private void MoveBall()
    {
        transform.DOMoveZ(-32, 2)
            .SetEase(Ease.Linear)
            .OnComplete(Disappear)
            .Play();
    }
}