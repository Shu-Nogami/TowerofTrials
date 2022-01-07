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
    public void EnemyAddDamage(int adddamage, int enemynumber){
        enemyList[enemynumber].GetComponent<EnemyParameters>().AddDamage(adddamage);
        isPlayerattack = false;
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
}
