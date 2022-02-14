using UnityEngine;
using UnityEngine.SceneManagement;

public sealed class GameOverSceneController : MonoBehaviour {

    public void OnClicked_Ok() {
        SceneManager.LoadScene("MainMenuScene");
    }
}
