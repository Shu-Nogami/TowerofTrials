using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleTargetButton : BaseButtonAction
{
    [SerializeField] private int targetNumber;
    public override void Click()
    {
        PlayerManager.playerinstance.AttackAction(targetNumber);
        UIManager.uiinstance.FinishTargetAction();
    }
}