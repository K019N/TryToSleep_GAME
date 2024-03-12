using UnityEngine;

public class TakeCamButtons : MonoBehaviour
{
    [SerializeField] GameObject questionPanel;
    [SerializeField] GameObject camPanel;
    [SerializeField] GameObject _toShow;
    [SerializeField] GameObject _toUse;
    
    //TODO: нормально сделать + сделать интерфейс для кнопок
    
    public void OnClickButtonNo(){
        print(0);
        questionPanel.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        _toUse.SetActive(false);
    }

    public void OnClickButtonYes(){
        print(1);
        camPanel.SetActive(true);
        OnClickButtonNo();
        _toShow.SetActive(true);
    }
}
