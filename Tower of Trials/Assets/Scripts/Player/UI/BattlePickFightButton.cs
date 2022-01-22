using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattlePickFightButton : BaseButtonAction
{
    public override void Click()
    {
        PlayerManager.playerinstance.SetTypeNumber(0);
        UIManager.uiinstance.ChangeTargetAction();
    }
}
