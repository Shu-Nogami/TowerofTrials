using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleTextNextButton : BaseButtonAction
{
    [SerializeField] private PlayerBattleTextUI battleText;
    public override void Click()
    {
        battleText.ViewText();
    }
}
