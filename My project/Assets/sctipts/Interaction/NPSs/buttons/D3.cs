using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class D3 : MonoBehaviour
{
    [SerializeField] private GameObject _beer;
    [SerializeField] private GameObject _pan;
    private void OnEnable(){
        _beer.SetActive(true);
        _pan.SetActive(false);
    }
}
