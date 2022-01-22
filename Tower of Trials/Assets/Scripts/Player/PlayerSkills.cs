using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using System;

public class PlayerSkills : MonoBehaviour
{
    [SerializeField] private List<GameObject> NotLearnedSkills = new List<GameObject>();
    private List<SkillStateValue> LearnedSkills = new List<SkillStateValue>();
    // Start is called before the first frame update
    void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    public void SetLearndSkill(SkillStateValue skill, GameObject skillObject){
        NotLearnedSkills.Remove(skillObject);
        LearnedSkills.Add(skill);
        LearnedSkills.Sort();
    }
    public SkillStateValue GetLearndSkill(int skillNumber){
        return LearnedSkills[skillNumber];
    }
    public string GetSkillName(int skillNumber){
        return LearnedSkills[skillNumber].GetSkillName();
    }
    public string GetSkillText(int skillNumber){
        return LearnedSkills[skillNumber].GetSkillText();
    }
    public int GetSkillNumber(){
        return LearnedSkills.Count;
    }
}
