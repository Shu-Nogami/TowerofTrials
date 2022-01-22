using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BattlePickFieldButton : BaseButtonAction
{
    private int fieldNumber;
    [SerializeField] private TextMeshProUGUI fieldNameText;
    public override void Click()
    {
        PlayerManager.playerinstance.SetIdNumber(fieldNumber);
        UIManager.uiinstance.ChangeTargetAction();
    }
    public override void OnPointerEnter()
    {
        SetFieldText();
    }
    private void SetFieldText(){
        UIManager.uiinstance.UpdateExplinText(fieldNumber, 0);
    }
    public void SetFieldNumber(int number){
        fieldNumber = number;
    }
    public void SetThisFieldButtonText(){
        fieldNameText.text = PlayerManager.playerinstance.GetSkillName(fieldNumber);
    }
}
