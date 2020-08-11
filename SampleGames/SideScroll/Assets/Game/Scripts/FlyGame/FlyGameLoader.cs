using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyGameLoader : MonoBehaviour
{
    [SerializeField] private GameObject obstacleRC;
    [SerializeField] private Transform obstacleParent;

    public List<Transform> obstaclePool = new List<Transform>();

    private void Awake()
    {
        obstaclePool.Clear();
        for (int i = 0; i < 20; i++)
        {
            CreateObstaclePool();
        }

        FlyGameManager.Instance.gameState = GameState.Play;
    }

    private void CreateObstaclePool()
    {
        var _obstacle = Instantiate(obstacleRC, obstacleParent);
        _obstacle.SetActive(false);
        obstaclePool.Add(_obstacle.transform);
    }
}
