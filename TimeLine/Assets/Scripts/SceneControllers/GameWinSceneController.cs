using UnityEngine;
using UnityEngine.SceneManagement;

public sealed class GameWinSceneController : MonoBehaviour {

    public void OnClicked_Ok() {
        SceneManager.LoadScene("MainMenuScene");
    }
}
