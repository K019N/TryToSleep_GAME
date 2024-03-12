using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScreen : MonoBehaviour
{
    [SerializeField] private GameObject _currentPanel;

    private void clickBase(){
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    public void startButton(){
        clickBase();
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        _currentPanel.SetActive(false);
    }

    public void exitButton(){
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #endif
        Application.Quit();
    }

    private void OnEnable(){
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}
