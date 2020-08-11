using UnityEngine;
using System.Linq;
using UnityEngine.UI;

public enum GameState
{
    Ready,
    Play,
    Over
}

public class GameManager : SimpleSingleTone<GameManager>
{
    [SerializeField] public PositionsUtils positionUtils;
    [SerializeField] private GameLoader gameLoader;

    [SerializeField] private float obstacleAppearTimeInterval = 3.0f;
    private float calcObstacleAppearTimeInterval;
    private float timer;

    [SerializeField] public GameState gameState = GameState.Ready;

    [SerializeField] private GameObject gameReadyPanel;
    [SerializeField] private GameObject gameOverPanel;

    [SerializeField] private int gamePoint;
    private float pointTimer;
    [SerializeField] private Text point;

    // Update is called once per frame
    private void Update()
    {
        if (gameState != GameState.Play) return;

        // appear obstacle
        timer += Time.deltaTime;
        if (timer >= calcObstacleAppearTimeInterval)
        {
            timer = 0;
            AppearObstacles();
        }

        // add game point
        SetGamePoint();

        // set game level
        SetGameLevel();
    }

    private void AppearObstacles()
    {
        // 障害物を取得
        var obstacle = gameLoader.obstaclePool.FirstOrDefault(x => !x.gameObject.activeSelf);

        // 出現ポイントと移動終了ポイントを決める
        var startPointIndex = Random.Range(0, positionUtils.positionCount);
        var endPointIndex = 0;
        if (startPointIndex == 0)
            endPointIndex = Random.Range(1, positionUtils.positionCount);
        else if (startPointIndex <= 10)
            endPointIndex = Random.Range(1, 10) + 9;
        else
            endPointIndex = Random.Range(1, 10);

        // ポイントを設定して障害物を出現させる
        if (obstacle != null)
            obstacle.GetComponent<ObstacleController>().SetPath(
                positionUtils.Positions[startPointIndex],
                positionUtils.Positions[endPointIndex]
            );
    }

    private void SetGamePoint()
    {
        pointTimer += Time.deltaTime;
        if (pointTimer > 1.0f)
        {
            gamePoint += 1;
            pointTimer = 0;
        }

        point.text = gamePoint.ToString();
    }

    private void SetGameLevel()
    {
        calcObstacleAppearTimeInterval =
            Mathf.Clamp(obstacleAppearTimeInterval - Mathf.CeilToInt(gamePoint / 60.0f) * 0.2f, 0.5f, 3.0f);
    }

    public void GameStart()
    {
        gameState = GameState.Play;
        gameOverPanel.SetActive(false);
        gameReadyPanel.SetActive(false);
        gamePoint = 0;
    }

    public void GameOver()
    {
        gameState = GameState.Over;
        gameOverPanel.SetActive(true);
    }
}