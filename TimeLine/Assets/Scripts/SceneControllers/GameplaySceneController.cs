using UnityEngine;
using UnityEngine.SceneManagement;

public sealed class GameplaySceneController : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start() {
        Debug.Log("Game Start");
    }

    public void LoseGame() {
        SceneManager.LoadScene("GameOverScene");
    }

    public void WinGame() {
        SceneManager.LoadScene("GameWinScene");
    }
}
