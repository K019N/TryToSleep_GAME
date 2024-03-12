using UnityEngine;

public class Bed : EClickable
{
    [SerializeField] private GameObject _cam;
    [SerializeField] private GameObject _losePanel;
    [SerializeField] private GameObject _winPanel;

    override protected void actionE(){
        _player.gameObject.SetActive(false);
        _cam.SetActive(true);
        _eToAct.SetActive(false);
        if(!_player.willWin()){
            _losePanel.SetActive(true);
        }
        else{
            _winPanel.SetActive(true);
        }
    }

    private void OnTriggerStay(Collider other){
        ((EClickable) this).clickECheck(other);
    }
}
