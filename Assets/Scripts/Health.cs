using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Health : MonoBehaviour
{
    [SerializeField] private int maxHealth;
    [SerializeField] private UnityEvent<int> healthChanged;

    private int health;

    public int Value
    {
        get {return health;}
    }

    public int MaxValue
    {
        get {return maxHealth;}
    }
    public void DecreaseHealth(int amount){
        health -= amount;
        healthChanged.Invoke(health);
    }

    public void LevelUp(){
        maxHealth += 10;
        health = maxHealth;
    }

    private void Awake(){
        health = maxHealth;
    }
}
 