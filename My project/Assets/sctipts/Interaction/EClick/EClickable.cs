using UnityEngine;

public abstract class EClickable : MonoBehaviour
{
    [SerializeField] protected StatesToSleep _player;
    [SerializeField] protected GameObject _eToAct; //Text
    [SerializeField] private string _name = "";
    protected bool isTaken = false;

    private void OnTriggerEnter(Collider other){
        _eToAct.SetActive(true);
    }

    private void OnTriggerExit(Collider other){
        _eToAct.SetActive(false);
    }

    public void  clickECheck(Collider other){
        if (other.gameObject.GetComponent<PersonController>() && 
        Input.GetKey(KeyCode.E)){
            actionE();
            isTaken = true;
        }
    }

    public string getName(){
        return _name;
    }

    abstract protected void actionE();
}
