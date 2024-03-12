using System.Collections;
using UnityEngine;

public class Door : EClickable
{
    private Transform _transform;
    private Collider _collider;
    private bool _isOpened;
    [SerializeField] private AudioSource _doorSound;
    [SerializeField] private GameObject _lockedText;

    private void Start(){
        _transform = GetComponent<Transform>();
        _collider = GetComponent<Collider>();
        _isOpened = true;
    }

    private void OnTriggerStay(Collider other){
        ((EClickable) this).clickECheck(other);
        if (other.gameObject.GetComponent<PersonController>() && 
        Input.GetKey(KeyCode.F) && _player.isKey()){
            _doorSound.Play();
            _isOpened = !_isOpened;
            if (!_isOpened){
                _player.addToDone(1);
                _player.addDoor(1);
            }
            else{
                _player.addToDone(-1);
                _player.addDoor(-1);
            }
            if (_transform.rotation == Quaternion.Euler(new Vector3(0, 0, 0))){
                _transform.Rotate(0, -90, 0);
            }
            StartCoroutine(wait(1));
            _eToAct.SetActive(false);
            print("key used");
        }
    }
    
    override protected void actionE(){
        _doorSound.Play();
        _eToAct.SetActive(false);
        if (_isOpened){
            if (_transform.rotation == Quaternion.Euler(new Vector3(0, -90, 0))){
                _transform.Rotate(0, 90, 0);
            }
            else{
                _transform.Rotate(0, -90, 0);
            }
            StartCoroutine(wait(1));
            print(123);
        }
    }

    private IEnumerator wait(int sec){
        _collider.enabled = false;
        yield return new WaitForSeconds(sec);
        _collider.enabled = true;
    }

    private void Update(){
        if (!_isOpened){
            _lockedText.SetActive(true);
        }
        else{
            _lockedText.SetActive(false);
        }
    }
}
