using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerParameters : PawnParameters, IDamage, IPlusXp, IPlusPortionState
{
    // Start is called before the first frame update
    void Start()
    {
        Initialize();
    }

    // Update is called once per frame
    void Update()
    {

    }
    /// <summary>
    /// パラメータの初期化
    /// </summary>
    protected override void Initialize()
    {
        hpValue.SetMaxNowValue(500, 3);
        xpValue.SetMaxNowValue(500, 0);
        manaValue.SetMaxNowValue(100, 100);
        level = 1;
        attackdamage = 1;
        critical = 0;
        defense = 0;
        money = 0;
    }
    /// <summary>
    /// 死亡時
    /// </summary>
    protected override void Dead()
    {
        Debug.Log("PlayerDead");
    }
    /// <summary>
    /// 敵からのダメージを受ける
    /// </summary>
    public void AddDamage(int damage){
        hpValue.CutNowValue(damage - defense);
        Debug.Log("Player's hp = " + hpValue.GetNowValue());
        if(hpValue.GetNowValue() == 0){
            Dead();
        }
    }
    /// <summary>
    /// 経験値取得
    /// </summary>
    public void AddXp(int plusxp){
        xpValue.AddNowValue(plusxp);
    }
    /// <summary>
    /// 攻撃力を渡す
    /// </summary>
    public int GetAttckDamage(){
        return attackdamage;
    }
    /// <summary>
    /// 使用したポーションの効果を反映
    /// </summary>
    public void EffectPortion(PlusParameters plusvalues){
        hpValue.AddNowValue(plusvalues.GetPlusHp());
        manaValue.AddNowValue(plusvalues.GetPlusMana());
        Debug.Log("Player HEAL hp = " + hpValue.GetNowValue());
    }
}