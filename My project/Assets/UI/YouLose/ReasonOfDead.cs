using UnityEngine;
using UnityEngine.UI;

public class ReasonOfDead : MonoBehaviour
{
    [SerializeField] private Text _txt;
    [SerializeField] private StatesToSleep _player;
    [SerializeField] private GameObject _dragonsFire;
    private string byKnife = "You were stabbed with your office knife";
    private string byVerwolf = "You did not lock the door and you were attacked by a werewolf";
    private string byDragon = "A little dragon burned down your house";
    private string bySecondDragon = "There is another dragon egg somewhere";

    private void OnEnable(){
        if(_player.getKnife() == 0){
            _txt.text = byKnife;
        }
        else if(_player.getDoor() == 0){
            _txt.text = byVerwolf;
        }
        else if(_player.getEggs() == 0){
            _txt.text = byDragon;
            _dragonsFire.SetActive(true);
        }
        else if(_player.getEggs() == 1){
            _txt.text = bySecondDragon;
            _dragonsFire.SetActive(true);
        }
        else{
            _txt.text = "";
        }
    }
}
