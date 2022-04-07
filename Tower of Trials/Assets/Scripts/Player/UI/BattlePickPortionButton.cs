using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattlePickPortionButton : BaseButtonAction
{
    public override void Click()
    {
        UIManager.uiinstance.ChengeField(2);
    }
}
