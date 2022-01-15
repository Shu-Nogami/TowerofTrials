using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillStateValue
{
    private string skillName;
    private int skillDamage;
    private int healHp;
    private int plusCritical;
    private int consumeMana;
    private int learningLevel;
    public void SetSkillName(string name){
        skillName = name;
    }
    public void SetDamage(int damage){
        skillDamage = damage;
    }
    public void SetHealHp(int hp){
        healHp = hp;
    }
    public void SetPlusCritical(int critical){
        plusCritical = critical;
    }
    public void SetConsumeMana(int mana){
        consumeMana = mana;
    }
    public void SetLearningLevel(int level){
        learningLevel = level;
    }
    public string GetSkillName(){
        return skillName;
    }
    public int GetDamage(){
        return skillDamage;
    }
    public int GetHealHp(){
        return healHp;
    }
    public int GetPlusCritical(){
        return plusCritical;
    }
    public int GetConsumeMana(){
        return consumeMana;
    }
    public int GetLearingLevel(){
        return learningLevel;
    }
}
