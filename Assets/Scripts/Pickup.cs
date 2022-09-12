using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    [SerializeField] private Experience exp;
    private void OnTriggerEnter2D(Collider2D col){
        if(col.CompareTag("Player")){
            var player = col.GetComponent<LevelSystem>();
            player.IncreaseExp(exp.getExpAmount());
            gameObject.SetActive(false);
        }
    }
}
