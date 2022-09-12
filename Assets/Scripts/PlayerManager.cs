using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    [SerializeField] private Transform playerTransformation;

    private static PlayerManager _instance;

    public static Vector2 Position{
        get {return (Vector2)_instance.playerTransformation.position;}
    }

    private void Awake(){
        _instance = this;
    }
}
