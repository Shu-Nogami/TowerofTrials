using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyParameters : PawnParameters, IDamage
{
    // Start is called before the first frame update
    void Start()
    {
        initialize();
    }

    // Update is called once per frame
    void Update()
    {
        //仮置き
        if(Input.GetKeyDown(KeyCode.Space)){
            BattleManager.battleinstance.PlayerAddDamage(attackdamage);
        }
    }
    protected override void initialize()
    {
        base.initialize();
    }
    public void AddDamage(int damage){
        hpValue.CutNowValue(damage - defense);
    }
    protected override void Dead()
    {
        Destroy(gameObject);
    }
}
