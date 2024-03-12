using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicianButtonClick : MonoBehaviour
{
    [SerializeField] private MagicianTalk magician;
    [SerializeField] private GameObject beer;

    public void OnClickButtonYes(){
        print(1);
        magician.closeDialogueWindow();
        magician.couterPlus();
        magician.openDialogueWindow();
    }
    public void OnClickButtonNo(){
        print(0);
        magician.closeDialogueWindow();
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
    
    
    public void showBeer(){
        beer.SetActive(true);
    }
}
