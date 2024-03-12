using System.Collections.Generic;
using UnityEngine;

public class StatesToSleep : MonoBehaviour
{
    [SerializeField] private int _done;
    private bool _isKey = false;
    private List<Thing> inventory = new List<Thing>();
    private bool _willDie;
    private int _allTasks = 4;

    private void Start(){
        _done = 0;
        _willDie = true;
    }

    public void addToDone(int act){
        _done += act;
        if (_done == _allTasks){
            _willDie = false;
        }
        else{
            _willDie = true;
        }
    }

    public void take(Thing sth, string sthName){
        inventory.Insert(0, sth);
        if (sthName == "key"){
            takeKey();
            print(12);
        }

        for (int i = 0; i < inventory.Count; i++){
            print(i);
        }
        print(10);
    }

    public void takeKey(){
        _isKey = true;
    }
    public bool isKey(){
        return _isKey;
    }
    public bool willWin(){
        return !_willDie;
    }

    //System for reson of death
    //TODO: переделать!!!!!!
    [SerializeField] private int _knifes = 1, _doorsLocked = 1, _eggs = 1;

    public void addKnife(int x){
        _knifes += x;
    }
    public int getKnife(){
        return _knifes;
    }

    public void addDoor(int x){
        _doorsLocked += x;
    }
    public int getDoor(){
        return _doorsLocked;
    }

    public void addEggs(int x){
        _eggs += x;
    }
    public int getEggs(){
        return _knifes;
    }
}
