using UnityEngine;
using UnityEngine.SceneManagement;

public sealed class MainMenuSceneController : MonoBehaviour {

    public void OnClicked_Play() {
        SceneManager.LoadScene("GameplayScene");
    }
}
