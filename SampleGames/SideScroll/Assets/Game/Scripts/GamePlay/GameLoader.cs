using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class GameLoader : MonoBehaviour
{
    [SerializeField] private GameObject obstacleRC;
    [SerializeField] private Transform obstacleParent;

    [SerializeField] private Transform player;
    [SerializeField] private GameObject playerAppearEffect;

    public List<Transform> obstaclePool = new List<Transform>();

    private void Awake()
    {
        player.localScale = Vector3.zero;

        obstaclePool.Clear();
        for (int i = 0; i < 20; i++)
        {
            CreateObstaclePool();
        }

        AppearPlayer();
    }

    private void CreateObstaclePool()
    {
        var _obstacle = Instantiate(obstacleRC, obstacleParent);
        _obstacle.SetActive(false);
        obstaclePool.Add(_obstacle.transform);
    }

    private void AppearPlayer()
    {
        playerAppearEffect.SetActive(true);
        player.DOScale(1, 1.0f)
            .SetEase(Ease.OutBounce)
            .SetDelay(0.5f)
            .OnComplete(() => { GameManager.Instance.GameStart(); })
            .Play();
    }
}