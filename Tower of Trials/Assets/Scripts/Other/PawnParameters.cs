using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PawnParameters : MonoBehaviour
{
    protected BarValue hpValue = new BarValue();
    protected BarValue xpValue = new BarValue();
    protected BarValue manaValue = new BarValue();
    protected int level;
    protected int attackdamage;
    protected int critical;
    protected int defense;
    protected int money;
    /// <summary>
    /// パラメータの値を初期化（上書き可）
    /// </summary>
    protected virtual void initialize(){
        hpValue.SetMaxNowValue(100, 100);
        xpValue.SetMaxNowValue(100, 0);
        manaValue.SetMaxNowValue(100, 100);
        level = 1;
        attackdamage = 100;
        critical = 0;
        defense = 100;
        money = 0;
    }
    /// <summary>
    /// 体力がなくなった時の処理（上書き可）
    /// </summary>
    protected virtual void Dead(){
        Debug.Log("dead");
    }
}
