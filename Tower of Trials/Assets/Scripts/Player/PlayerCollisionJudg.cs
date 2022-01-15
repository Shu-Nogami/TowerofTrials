using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisionJudg : MonoBehaviour
{
    [SerializeField] private int directionNumber;
    void OnTriggerEnter(Collider collistion){
        if(collistion.tag == "Wall"){
            PlayerManager.playerinstance.UpdateMoveDirection(directionNumber, false);
        }
    }
    void OnTriggerExit(Collider collistion){
        if(collistion.tag == "Wall"){
            PlayerManager.playerinstance.UpdateMoveDirection(directionNumber, true);
        }
    }
}
