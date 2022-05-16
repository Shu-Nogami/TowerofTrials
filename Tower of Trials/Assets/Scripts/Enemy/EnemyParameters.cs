using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyParameters : PawnParameters, IDamage
{
    [SerializeField] private Image enemyImage;
    // Start is called before the first frame update
    void Start()
    {
        this.Initialize();
        this.SetUp();
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
    /// 戦闘開始時の準備
    /// </summary>
    private void SetUp(){
        BattleManager.battleinstance.AddEnemyList(this.gameObject);
        UIManager.uiinstance.AddEnemyImage(this.enemyImage);
        UIManager.uiinstance.ReflectEnemyImage();
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
        BattleManager.battleinstance.EnemyDead(this.gameObject);
    }
    public int GetAttackDamage(){
        return attackdamage;
    }
    public string GetEnemyName(){
        return thisName;
    }
}
