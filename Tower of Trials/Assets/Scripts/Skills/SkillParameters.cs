using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

public class SkillParameters : MonoBehaviour
{
    protected SkillStateValue skillValues = new SkillStateValue();
    protected virtual void Start(){
        PlayerManager.playerinstance.LeaningSkill.Where(level => level == skillValues.GetLearingLevel())
                                                 .Subscribe(level => {SetSkill();});
    }
    /// <summary>
    /// スキルの内容初期化
    /// </summary>
    protected virtual void SkillInitialize(){
        skillValues.SetSkillName("");
        skillValues.SetDamage(0);
        skillValues.SetHealHp(0);
        skillValues.SetPlusCritical(0);
        skillValues.SetConsumeMana(0);
        skillValues.SetLearningLevel(1);
        skillValues.SetSkillText("");
        skillValues.SetIsUsedSkill(false);
    }
    /// <summary>
    /// スキル修得
    /// </summary>
    private void SetSkill(){
        if(skillValues.GetIsUsedSkill() == false){
            PlayerManager.playerinstance.LearningSkill(skillValues, gameObject);
            Destroy(gameObject);
            skillValues.SetIsUsedSkill(true);
        }
    }
}