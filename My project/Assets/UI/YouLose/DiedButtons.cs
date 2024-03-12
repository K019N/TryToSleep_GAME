using UnityEngine;
using UnityEngine.SceneManagement;

public class DiedButtons : MonoBehaviour
{
    [SerializeField] private GameObject _currentPanel;
    [SerializeField] private GameObject _menu;

    private void clickBase(){
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    public void restartScene(){
        _currentPanel.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        _menu.SetActive(false);
        clickBase();
    }

    public void toMenu(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    private void OnEnable(){
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}
