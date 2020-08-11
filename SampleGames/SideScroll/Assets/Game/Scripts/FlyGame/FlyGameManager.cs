using UnityEngine;
using System.Linq;

public class FlyGameManager : SimpleSingleTone<FlyGameManager>
{
    [SerializeField] private FlyGameLoader gameLoader;

    [SerializeField] private float obstacleAppearTimeInterval = 1.0f;
    private float timer;

    [SerializeField] public GameState gameState = GameState.Ready;

    [SerializeField] private GameObject gameOverCanvas;


    // Update is called once per frame
    private void Update()
    {
        if (gameState != GameState.Play) return;

        timer += Time.deltaTime;
        if (timer >= obstacleAppearTimeInterval)
        {
            timer = 0;
            ObstacleAppearStart();
        }
    }

    private void ObstacleAppearStart()
    {
        // 障害物を取得
        var obstacle = gameLoader.obstaclePool.FirstOrDefault(x => !x.gameObject.activeSelf);

        // ポイントを設定して障害物を出現させる
        if (obstacle != null)
            obstacle.GetComponent<FlyGameObstacleController>().Appear();
    }

    public void GameOver()
    {
        gameState = GameState.Over;
        gameOverCanvas.SetActive(true);
    }
}