using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattlePickFightButton : BaseButtonAction
{
    public override void Click()
    {
        UIManager.uiinstance.ChangeTargetAction();
    }
}
