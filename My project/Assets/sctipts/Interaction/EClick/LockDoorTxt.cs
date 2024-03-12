using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockDoorTxt : MonoBehaviour
{
    [SerializeField] private StatesToSleep _player;

    private void Update(){
        if (_player.isKey()){
            gameObject.SetActive(true);
        }
    }
}
