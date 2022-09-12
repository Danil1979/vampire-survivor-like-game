using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class Experience : MonoBehaviour
{
    [SerializeField] private int expAmount;
    [SerializeField] private GameObject expPrefab;
    [SerializeField] private Transform enemyTransform;

    private Experience test;

public void dropExperience(){
    Instantiate(expPrefab, enemyTransform.position, Quaternion.identity).GetComponent<Experience>().expAmount = expAmount;
}
public int getExpAmount(){
    return expAmount;
}
}
