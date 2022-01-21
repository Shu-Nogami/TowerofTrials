using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// コマンドバトルで使用するシングルトン
/// </summary>
public class BattleManager : MonoBehaviour
{
    public static BattleManager battleinstance;
    [SerializeField] private GameObject player;
    private PlayerParameters Pparameters;
    List<GameObject> enemyList = new List<GameObject>();
    public bool isPlayerattack = true;
    public bool isBattle = true;

    private void Awake(){
        if(battleinstance == null){
            battleinstance = this;
            DontDestroyOnLoad(gameObject);
        }
        else{
            Destroy(gameObject);
        }
        Pparameters = player.GetComponent<PlayerParameters>();
    }

    private void Update(){
        if(!isPlayerattack){
            EnemiesAction();
        }
    }
    /// <summary>
    /// 敵をリストに入れる
    /// </summary>
    public void AddEnemyList(GameObject enemy){
        enemyList.Add(enemy);
    }
    /// <summary>
    /// 敵からプレイヤーに対してのダメージ
    /// </summary>
    public void PlayerAddDamage(int adddamage){
        Pparameters.AddDamage(adddamage);
    }
    /// <summary>
    /// プレイヤーから敵に対してのダメージ
    /// </summary>
    public void EnemyAddDamage(int adddamage, int enemyNumber){
        enemyList[enemyNumber].GetComponent<EnemyParameters>().AddDamage(adddamage);
        Debug.Log("Enemy Damaged : " + adddamage);
        isPlayerattack = false;
    }
    public void UsedSkill(SkillStateValue skillValue, int targetNumber){
        if(targetNumber == -1){
            PlayerAddDamage(skillValue.GetDamage());
        }
        else{
            EnemyAddDamage(skillValue.GetDamage(), targetNumber);
        }
    }
    /// <summary>
    /// それぞれの敵の行動を実行する
    /// </summary>
    private void EnemiesAction(){
        foreach(GameObject enemy in enemyList){
            enemy.GetComponent<EnemyActions>().Actions();
        }
        isPlayerattack = true;
    }
    public List<GameObject> GetEnemyList(){
        return enemyList;
    }
}
