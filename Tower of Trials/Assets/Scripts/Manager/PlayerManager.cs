using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using System;

public class PlayerManager : MonoBehaviour
{
    public static PlayerManager playerinstance;
    [SerializeField] private GameObject player;
    private PlayerParameters Pparamegers;
    private PlayerItems Pitems;
    private PlayerActions Pactions;
    private PlayerSkills Pskills;
    private Subject<int> skillSubject = new Subject<int>();
    private List<bool> isMoveDirection = new List<bool>();
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
        Pparamegers = player.GetComponent<PlayerParameters>();
        Pitems = player.GetComponent<PlayerItems>();
        Pactions = player.GetComponent<PlayerActions>();
        Pskills = player.GetComponent<PlayerSkills>();
        Pitems.SetWeaponState("test", 10, 0, 0);
        for(int i = 0;i < 4;i++){
            isMoveDirection.Add(true);
        }
    }
    public void AttackAction(int targetNumber){
        if(targetNumber == -1){
            BattleManager.battleinstance.PlayerAddDamage(Pparamegers.GetAttckDamage());
        }
        else{
            BattleManager.battleinstance.EnemyAddDamage(Pparamegers.GetAttckDamage(), targetNumber);
        }
        BattleManager.battleinstance.isPlayerattack = false;
    }
    public void SkillAction(int skillNumber, int targetNumber){
        BattleManager.battleinstance.UsedSkill(Pskills.GetLearndSkill(skillNumber), targetNumber);
    }
    public void LearningSkill(SkillStateValue skill, GameObject skillObject){
        Pskills.SetLearndSkill(skill, skillObject);
    }
    public void LevelUp(int level){
        skillSubject.OnNext(level + 1);
        Pparamegers.StatusAtLevelUp();
    }
    public void UpdateMoveDirection(int directionNumber, bool moveBool){
        isMoveDirection[directionNumber] = moveBool;
    }
    public bool GetMoveDirection(int directionNumber){
        return isMoveDirection[directionNumber];
    }
    public void UpdateHpBar(){
        UIManager.uiinstance.UpdatePlayerHpBars(Pparamegers.GetHpMaxValue(), Pparamegers.GetHpNowValue());
    }
    public void UPdateManaBar(){
        UIManager.uiinstance.UpdatePlayerManaBars(Pparamegers.GetManaMaxValue(), Pparamegers.GetManaNowValue());
    }
}
