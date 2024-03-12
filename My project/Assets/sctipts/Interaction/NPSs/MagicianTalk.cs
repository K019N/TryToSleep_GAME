using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicianTalk : EClickable
{
    int counter = 0;
    [SerializeField] List<GameObject> lst;

    override protected void actionE(){
        Cursor.visible = true;
        _eToAct.SetActive(false);
        Cursor.lockState = CursorLockMode.None;
        openDialogueWindow();
    }

    private void OnTriggerStay(Collider other){
        ((EClickable) this).clickECheck(other);
    }

    public void openDialogueWindow(){
        if (lst[counter]) lst[counter].SetActive(true);
        else Cursor.lockState = CursorLockMode.Locked;
    }

    public void closeDialogueWindow(){
        lst[counter].SetActive(false);
    }

    public void couterPlus(){
        counter++;
    }
    public void counterToZero(){
        counter = 0;
    }
}
