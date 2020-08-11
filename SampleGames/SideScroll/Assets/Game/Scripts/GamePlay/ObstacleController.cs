using UnityEngine;
using DG.Tweening;

public class ObstacleController : MonoBehaviour
{
    private Vector3 moveEndPoint;

    [SerializeField] private GameObject appearEffect;
    [SerializeField] private GameObject disappearEffect;

    [SerializeField] private AudioSource moveSe;
    [SerializeField] private AudioSource explosionSe;

    public void SetPath(Vector3 start, Vector3 end)
    {
        transform.position = start;
        moveEndPoint = end;
        Appear();
    }

    private void Appear()
    {
        transform.localScale = Vector3.zero;
        transform.gameObject.SetActive(true);
        
        var _effect = Instantiate(appearEffect);
        _effect.transform.position = transform.position;
        
        transform.DOScale(Vector3.one * 5, 1)
            .SetEase(Ease.OutBack)
            .SetDelay(0.5f)
            .OnComplete(MoveBall)
            .Play();
    }

    private void Disappear()
    {
        explosionSe.Play();
        var _effect = Instantiate(disappearEffect);
        _effect.transform.position = transform.position;
        
        transform.DOScale(Vector3.zero, 0.5f)
            .SetEase(Ease.InBounce)
            .OnComplete(() => { gameObject.SetActive(false); })
            .Play();
    }

    private void MoveBall()
    {
        var randomMoveDuration = Random.Range(1.0f, 3.0f);
        moveSe.Play();
        transform.DOMove(moveEndPoint, randomMoveDuration)
            .SetEase(GetRandomMoveType())
            .SetDelay(0.2f)
            .OnComplete(Disappear)
            .Play();
    }

    private Ease GetRandomMoveType()
    {
        var x = UnityEngine.Random.Range(0, 4);
        switch (x)
        {
            case 0:
                return Ease.InOutQuad;
            case 1:
                return Ease.OutCubic;
            case 2:
                return Ease.InQuart;
            default:
                return Ease.Linear;
        }
    }
}