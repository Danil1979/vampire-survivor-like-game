using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class LevelSystem : MonoBehaviour
{

    [SerializeField] private UnityEvent<int> expChanged;
    [SerializeField] private Health health;

    private int _exp;
    private int level;
    private int experienceToNextLevel;

    public int Value
    {
        get {return _exp;}
    }

    public LevelSystem(){
        level = 1;
        experienceToNextLevel = 10;
        _exp = 0;
    }

    public void IncreaseExp(int point){
        _exp += point;
        Debug.Log(point);
        Debug.Log(_exp + "exp");
        if(_exp >= experienceToNextLevel){
            level++;
            _exp -= experienceToNextLevel;
            health.LevelUp();
        }
        expChanged.Invoke(_exp);
    }
}
