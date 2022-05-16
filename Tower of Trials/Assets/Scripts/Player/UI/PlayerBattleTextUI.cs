using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerBattleTextUI : BaseBattleUI
{
    [SerializeField] private TextMeshProUGUI battleText;
    private List<string> textMessages = new List<string>();
    private int textCount = 0;
    public void AddBattleText(string text){
        textMessages.Add(text);
    }
    public void ViewText(){
        if(textCount < textMessages.Count){
            battleText.text = textMessages[textCount];
            textCount++;
        }
        else{
            textCount = 0;
            textMessages.Clear();
            BattleManager.battleinstance.ChangeIsPlayerAttack();
            if(BattleManager.battleinstance.isPlayerattack == true){
                UIManager.uiinstance.FinishTargetAction();
            }
        }
    }
}
