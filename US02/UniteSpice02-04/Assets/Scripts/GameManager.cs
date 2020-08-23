using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static void LoadGameOver()
    {
        SceneManager.LoadScene("GameOver");
    }

    public static void LoadGameClear()
    {
        SceneManager.LoadScene("GameClear");
    }
}
