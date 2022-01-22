using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    public static UIManager uiinstance;
    [SerializeField] private GameObject player;
    private PlayerBattlePickUI battlePick;
    private PlayerBattleTargetUI battleTarget;
    [SerializeField] private TextMeshProUGUI explainText;
    private void Awake(){
        if(uiinstance == null){
            uiinstance = this;
            DontDestroyOnLoad(gameObject);
        }
        else{
            Destroy(gameObject);
        }
        battlePick = player.GetComponent<PlayerBattlePickUI>();
        battleTarget = player.GetComponent<PlayerBattleTargetUI>();
    }
    public void UpdatePlayerHpBars(int playerMaxValue, int playerNowValue){
        battlePick.SetPlayerHPBar(playerMaxValue, playerNowValue);
        battleTarget.SetPlayerHPBar(playerMaxValue, playerNowValue);
    }
    public void UpdatePlayerManaBars(int playerMaxValue, int playerNowValue){
        battlePick.SetPlayerManaBar(playerMaxValue, playerNowValue);
        battleTarget.SetPlayerManaBar(playerMaxValue, playerNowValue);
    }
    private void SetEnemyNameList(List<GameObject> enemyList){
        battleTarget.UpdateEnemyButton(enemyList);
    }
    public void ChangeTargetAction(){
        SetEnemyNameList(BattleManager.battleinstance.GetEnemyList());
        battlePick.GetThisObj().SetActive(false);
        battleTarget.GetThisObj().SetActive(true);
    }
    public void FinishTargetAction(){
        battleTarget.GetThisObj().SetActive(false);
        battlePick.GetThisObj().SetActive(true);
    }
    public void UpdateExplinText(int idNumber, int typeNumber){
        if(typeNumber == 0){
            battlePick.SetFieldText(PlayerManager.playerinstance.GetSkilltext(idNumber));
        }
    }
    public void ChengeField(int typeNumber){
        PlayerManager.playerinstance.SetTypeNumber(typeNumber);
        battlePick.SetTypeNumber(typeNumber);
        battlePick.UpdateItemFieldButton();
    }
}
