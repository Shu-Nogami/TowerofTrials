using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerBattlePickUI : BaseBattleUI
{
    private int pageNumber;
    private int buttonNumber;
    private int itemNumber;
    private int typeNumber = -1;
    private int i;
    [SerializeField] private TextMeshProUGUI fieldText;
    [SerializeField] private List<GameObject> fieldButton = new List<GameObject>();
    private List<BattlePickFieldButton> fieldButtonController = new List<BattlePickFieldButton>();
    private void Awake(){
        for(i = 0;i < fieldButton.Count;i++){
            fieldButtonController.Add(fieldButton[i].GetComponent<BattlePickFieldButton>());
        }
        UpdateItemFieldButton();
    }
    public void UpdateItemFieldButton(){
        if(typeNumber == -1){
            for(i = 0;i < fieldButton.Count;i++){
                fieldButton[i].SetActive(false);
            }
        }
        if(typeNumber == 1 || typeNumber == 2){
            if(typeNumber == 1){
                itemNumber = PlayerManager.playerinstance.GetSkillNumber();
            }
            else if(typeNumber == 2){
                itemNumber = PortionManager.portioninstance.GetPortionNumber();
            }
            if(fieldButton.Count > itemNumber - (fieldButton.Count * pageNumber)){
                buttonNumber = itemNumber - (fieldButton.Count * pageNumber);
            }
            else{
                buttonNumber = fieldButton.Count;
            }
            for(i = 0;i < buttonNumber;i++){
                fieldButton[i].SetActive(true);
                fieldButtonController[i].SetFieldNumber(i + fieldButton.Count * pageNumber);
                fieldButtonController[i].SetThisFieldButtonText();
            }
            for(;i < fieldButton.Count;i++){
                fieldButton[i].SetActive(false);
            }
        }
    }
    public void SetTypeNumber(int number){
        typeNumber = number;
    }
    public void SetFieldText(string textMessage){
        fieldText.text = textMessage;
    }
    public int GetTypeNumber(){
        return typeNumber;
    }
}
