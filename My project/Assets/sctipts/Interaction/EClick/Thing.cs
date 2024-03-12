using UnityEngine;

public class Thing : EClickable
{
    [SerializeField] GameObject camPanel;
    [SerializeField] GameObject FLockText;
    [SerializeField] GameObject _camToUse;
    [SerializeField] AudioSource _pickSound;
    
    override protected void actionE(){
        _pickSound.Play();
        string n = getName();
        if (n == "cam"){
            camPanel.SetActive(true);
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            _camToUse.SetActive(true);
        }
        if (n == "key"){
            camPanel.SetActive(false);
            FLockText.SetActive(true);
            
        }
        if (n == "knife"){
            _player.addToDone(1);
            _player.addKnife(1);
        }
        if (n == "egg"){
            _player.addToDone(1);
            _player.addEggs(1);
        }
        gameObject.SetActive(false);
        _eToAct.SetActive(false);
        _player.take(this, n);
    }

    private void OnTriggerStay(Collider other){
        ((EClickable) this).clickECheck(other);
    }
}
