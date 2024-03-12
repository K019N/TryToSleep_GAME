using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenLore : MonoBehaviour
{
    [SerializeField] private GameObject _lore;

    public void onLore(){
        _lore.SetActive(true);
    }
}
