using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// コマンドバトルで使用するシングルトン
/// </summary>
public class BattleManager : MonoBehaviour
{
    public static BattleManager battleinstance { get; private set; }
    [SerializeField] List<GameObject> enemyList = new List<GameObject>();
    public bool isPlayerattack = true;
    public bool isBattle = false;
    private bool test = false;

    private void Awake(){
        if(battleinstance == null){
            battleinstance = this;
            DontDestroyOnLoad(gameObject);
        }
        else{
            Destroy(gameObject);
        }
    }
    private void Update(){
        if(Input.GetKeyDown(KeyCode.S)){
            if(test == false){
                test = true;
                isBattle = true;
                this.BattleSetUp();
            }
        }
    }
    public void BattleSetUp(){
        UIManager.uiinstance.FirstBattleUI();
        EnemyManager.enemyinstance.SpawnEnemy();
    }
    /// <summary>
    /// 敵をリストに入れる
    /// </summary>
    public void AddEnemyList(GameObject enemy){
        enemyList.Add(enemy);
    }
    /// <summary>
    /// プレイヤーに対してのダメージ
    /// </summary>
    public void PlayerAddDamage(int adddamage){
        PlayerManager.playerinstance.AddDamage(adddamage);
        UIManager.uiinstance.SetBattleText("Player Damaged : " + adddamage);
    }
    /// <summary>
    /// プレイヤーから敵に対してのダメージ
    /// </summary>
    public void EnemyAddDamage(int adddamage, int enemyNumber){
        enemyList[enemyNumber].GetComponent<EnemyParameters>().AddDamage(adddamage);
        UIManager.uiinstance.SetBattleText("Enemy Damaged : " + adddamage);
        Debug.Log("Enemy Damaged : " + adddamage);
        UIManager.uiinstance.ChangeBattleText();
    }
    /// <summary>
    /// スキルを指定した対象に使用する
    /// </sumamry>
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
            Debug.Log("1");
        }
        UIManager.uiinstance.ChangeBattleText();
    }
    public List<GameObject> GetEnemyList(){
        return enemyList;
    }
    public int GetEnemyListCount(){
        return enemyList.Count;
    }
    public void EnemyDead(GameObject enemy){
        enemyList.Remove(enemy);
        if(enemyList.Count == 0){
            this.BattleEnd();
        }
    }
    private void BattleEnd(){
        UnityEditor.EditorApplication.isPlaying = false;
    }
    public void ChangeIsPlayerAttack(){
        isPlayerattack = !isPlayerattack;
        this.JudgeEnemyAttack();
    }
    private void JudgeEnemyAttack(){
        if(isPlayerattack == false){
            this.EnemiesAction();
        }
    }
}
