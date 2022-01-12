using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneralManager : MonoBehaviour
{
    public static GeneralManager generalinstance;
    private void Awake(){
        if(generalinstance == null){
            generalinstance = this;
            DontDestroyOnLoad(gameObject);
        }
        else{
            Destroy(gameObject);
        }
    }
    public void PlayerToEnemyDamage(int damage, int enemynumber){
        BattleManager.battleinstance.EnemyAddDamage(damage, enemynumber);
    }
}
