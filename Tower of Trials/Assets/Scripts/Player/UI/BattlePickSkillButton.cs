using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattlePickSkillButton : BaseButtonAction
{
    public override void Click()
    {
        UIManager.uiinstance.ChengeField(1);
    }
}