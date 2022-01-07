using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyActions : MonoBehaviour
{
    EnemyParameters myparameters;
    private int random = 1;
    // Start is called before the first frame update
    void Start()
    {
        myparameters = this.GetComponent<EnemyParameters>();
    }

    public void Actions(){
        //random = Random.Range(1, 2);
        switch(random){
            case 1:
                BattleManager.battleinstance.PlayerAddDamage(myparameters.GetAttackDamage());
                break;
            default:
                break;
        }
    }
}
