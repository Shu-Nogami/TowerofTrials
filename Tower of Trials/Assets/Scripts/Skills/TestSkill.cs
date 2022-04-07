using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestSkill : SkillParameters
{
    protected override void Start()
    {
        SkillInitialize();
        base.Start();
    }

    protected override void SkillInitialize()
    {
        base.SkillInitialize();
        skillValues.SetSkillName("TestSkill");
        skillValues.SetDamage(20);
        skillValues.SetConsumeMana(20);
        skillValues.SetLearningLevel(2);
        skillValues.SetSkillText("TestText");
    }
}
