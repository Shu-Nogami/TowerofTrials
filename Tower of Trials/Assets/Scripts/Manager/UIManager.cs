using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    public static UIManager uiinstance { get; private set;}
    [SerializeField] private PlayerBattlePickUI battlePick;
    [SerializeField] private PlayerBattleTargetUI battleTarget;
    [SerializeField] private PlayerBattleTextUI battleText;
    [SerializeField] private PlayerBattleEnemyViewUI battleView;
    [SerializeField] private TextMeshProUGUI explainText;
    [SerializeField] private List<Image> enemyImages = new List<Image>();
    private void Awake(){
        if(uiinstance == null){
            uiinstance = this;
            DontDestroyOnLoad(gameObject);
        }
        else{
            Destroy(gameObject);
        }
    }
    /// <summary>
    /// プレイヤーのHPバーを更新する
    /// </sumamry>
    public void UpdatePlayerHpBars(int playerMaxValue, int playerNowValue){
        battlePick.SetPlayerHPBar(playerMaxValue, playerNowValue);
        battleTarget.SetPlayerHPBar(playerMaxValue, playerNowValue);
        battleText.SetPlayerHPBar(playerMaxValue, playerNowValue);
    }
    /// <summary>
    /// プレイヤーのManaバーを更新する
    /// </sumamry>
    public void UpdatePlayerManaBars(int playerMaxValue, int playerNowValue){
        battlePick.SetPlayerManaBar(playerMaxValue, playerNowValue);
        battleTarget.SetPlayerManaBar(playerMaxValue, playerNowValue);
        battleText.SetPlayerManaBar(playerMaxValue, playerNowValue);
    }
    /// <summary>
    /// 敵の名前をセットする
    /// </sumamry>
    private void SetEnemyNameList(List<GameObject> enemyList){
        battleTarget.UpdateEnemyButton(enemyList);
    }
    public void FirstBattleUI(){
        this.battlePick.GetThisObj().SetActive(true);
        this.battleView.GetThisObj().SetActive(true);
    }
    public void ChangeTargetAction(){
        SetEnemyNameList(BattleManager.battleinstance.GetEnemyList());
        battlePick.GetThisObj().SetActive(false);
        battleTarget.GetThisObj().SetActive(true);
    }
    public void FinishTargetAction(){
        battlePick.ResetFieldUI();
        battleText.GetThisObj().SetActive(false);
        battlePick.GetThisObj().SetActive(true);
    }
    public void UpdateExplinText(int idNumber){
        switch(battlePick.GetTypeNumber()){
            case 1:
                battlePick.SetFieldText(PlayerManager.playerinstance.GetSkilltext(idNumber));
                break;
            case 2:
                break;
            default:
                break;
        }
    }
    public void ChengeField(int typeNumber){
        PlayerManager.playerinstance.SetTypeNumber(typeNumber);
        battlePick.SetTypeNumber(typeNumber);
        battlePick.UpdateItemFieldButton();
    }
    public void SetBattleText(string text){
        battleText.AddBattleText(text);
    }
    public void ChangeBattleText(){
        battleTarget.GetThisObj().SetActive(false);
        battleText.GetThisObj().SetActive(true);
        battleText.ViewText();
    }
    /// <summary>
    /// 敵の画像を追加
    /// </summary>
    public void AddEnemyImage(Image enemyImage){
        enemyImages.Add(enemyImage);
    }
    /// <sumamry>
    /// 敵の画像を画面に反映
    /// </sumamry>
    public void ReflectEnemyImage(){
        this.battleView.SetEnemyImages(this.enemyImages);
    }
}
