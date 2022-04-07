using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyParameters : PawnParameters, IDamage
{
    // Start is called before the first frame update
    void Start()
    {
        Initialize();
        BattleManager.battleinstance.AddEnemyList(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {

    }
    protected override void Initialize()
    {
        base.Initialize();
        defense = 0;
    }
    /// <summary>
    /// この敵にダメージを与える
    /// </summary>
    public void AddDamage(int damage){
        hpValue.CutNowValue(damage - defense);
        Debug.Log("enemy's hp = " + hpValue.GetNowValue());
        if(hpValue.GetNowValue() == 0){
            Dead();
        }
    }
    /// <summary>
    /// 死亡時
    /// </summary>
    protected override void Dead()
    {
        Debug.Log("Enemy Dead");
        Destroy(this.gameObject);
    }
    public int GetAttackDamage(){
        return attackdamage;
    }
    public string GetEnemyName(){
        return thisName;
    }
}
