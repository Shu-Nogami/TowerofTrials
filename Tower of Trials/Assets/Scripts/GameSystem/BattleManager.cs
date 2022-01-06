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
    }
}
