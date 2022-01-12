using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public static PlayerManager playerinstance;
    [SerializeField] private GameObject player;
    private PlayerParameters Pparamegers;
    private PlayerItems Pitems;
    private PlayerActions Pactions;
    private void Awake(){
        if(playerinstance == null){
            playerinstance = this;
            DontDestroyOnLoad(gameObject);
        }
        else{
            Destroy(gameObject);
        }
        Pparamegers = player.GetComponent<PlayerParameters>();
        Pitems = player.GetComponent<PlayerItems>();
        Pactions = player.GetComponent<PlayerActions>();
        Pitems.SetWeaponState("test", 10, 0, 0);
    }
    public void AttackAction(int enemynumber){
        GeneralManager.generalinstance.PlayerToEnemyDamage(Pparamegers.GetAttckDamage() + Pitems.GetItemsAttackDamage(), enemynumber);
    }
}
