using UnityEngine.SceneManagement;

public class GameMaster
{
	public static void MoveClear()
	{
        SceneManager.LoadScene("Clear");
    }

	public static void MoveGameOver()
	{
        SceneManager.LoadScene("GameOver");
	}
}
