using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using System;

public class PlayerManager : MonoBehaviour
{
    public static PlayerManager playerinstance { get; private set; }
    [SerializeField] private GameObject player;
    private PlayerParameters Pparameters;
    private PlayerItems Pitems;
    private PlayerActions Pactions;
    private PlayerSkills Pskills;
    private Subject<int> skillSubject = new Subject<int>();
    private List<bool> isMoveDirection = new List<bool>();
    private int idNumber;
    private int typeNumber;
    public IObservable<int> LeaningSkill{
        get {return skillSubject; }
    }
    private void Awake(){
        if(playerinstance == null){
            playerinstance = this;
            DontDestroyOnLoad(gameObject);
        }
        else{
            Destroy(gameObject);
        }
        Pparameters = player.GetComponent<PlayerParameters>();
        Pitems = player.GetComponent<PlayerItems>();
        Pactions = player.GetComponent<PlayerActions>();
        Pskills = player.GetComponent<PlayerSkills>();
        Pitems.SetWeaponState("test", 10, 0, 0);
        for(int i = 0;i < 4;i++){
            isMoveDirection.Add(true);
        }
    }
    /// <summary>
    /// バトル時、プレイヤーの行動一覧
    /// </summary>
    public void AttackAction(int targetNumber){
        if(typeNumber == 0){
            NormalAttackAction(targetNumber);
        }
        else if(typeNumber == 1){
            SkillAction(idNumber, targetNumber);
        }
        else if(typeNumber == 2){
            PortionAction(idNumber);
        }
    }
    /// <summary>
    /// 通常攻撃時、攻撃対象にダメージを与える
    /// </summary>
    private void NormalAttackAction(int targetNumber){
        if(targetNumber == -1){
            BattleManager.battleinstance.PlayerAddDamage(Pparameters.GetAttckDamage());
            UIManager.uiinstance.ChangeBattleText();
        }
        else{
            BattleManager.battleinstance.EnemyAddDamage(Pparameters.GetAttckDamage(), targetNumber);
        }
    }
    private void SkillAction(int skillNumber, int targetNumber){
        BattleManager.battleinstance.UsedSkill(Pskills.GetLearndSkill(skillNumber), targetNumber);
        UIManager.uiinstance.ChangeBattleText();
    }
    private void PortionAction(int potionNumber){
        PortionManager.portioninstance.UsedPortion(potionNumber);
    }
    public void LearningSkill(SkillStateValue skill, GameObject skillObject){
        Pskills.SetLearndSkill(skill, skillObject);
    }
    public void LevelUp(int level){
        skillSubject.OnNext(level + 1);
        Pparameters.StatusAtLevelUp();
    }
    public void UpdateMoveDirection(int directionNumber, bool moveBool){
        isMoveDirection[directionNumber] = moveBool;
    }
    public bool GetMoveDirection(int directionNumber){
        return isMoveDirection[directionNumber];
    }
    public void UpdateHpBar(){
        UIManager.uiinstance.UpdatePlayerHpBars(Pparameters.GetHpMaxValue(), Pparameters.GetHpNowValue());
    }
    public void UPdateManaBar(){
        UIManager.uiinstance.UpdatePlayerManaBars(Pparameters.GetManaMaxValue(), Pparameters.GetManaNowValue());
    }
    public string GetSkilltext(int skillNumber){
        return Pskills.GetSkillText(skillNumber);
    }
    public string GetSkillName(int skillNumber){
        return Pskills.GetSkillName(skillNumber);
    }
    public void AddDamage(int adddamage){
        Pparameters.AddDamage(adddamage);
    }
    public void SetIdNumber(int number){
        idNumber = number;
    }
    public void SetTypeNumber(int number){
        typeNumber = number;
    }
    public int GetSkillNumber(){
        return Pskills.GetSkillNumber();
    }
}
