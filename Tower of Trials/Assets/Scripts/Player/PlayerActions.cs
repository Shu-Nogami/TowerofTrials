using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerActions : MonoBehaviour
{
    PlayerParameters Pparameters;
    // Start is called before the first frame update
    void Start()
    {
        Pparameters = this.gameObject.GetComponent<PlayerParameters>();
    }

    // Update is called once per frame
    void Update()
    {
        if(BattleManager.battleinstance.isBattle){
            PlayerActionList();
        }
    }
    /// <summary>
    /// 戦闘時、プレイヤーの行動一覧
    /// </summary>
    private void PlayerActionList(){
        if(BattleManager.battleinstance.isPlayerattack){
            if(Input.GetKeyDown(KeyCode.I)){
                EffectPortion(0);
                BattleManager.battleinstance.isPlayerattack = false;
            }
            if(Input.GetKeyDown(KeyCode.U)){
                PlayerManager.playerinstance.LevelUp(1);
                BattleManager.battleinstance.isPlayerattack = false;
            }
            if(Input.GetKeyDown(KeyCode.S)){
                PlayerManager.playerinstance.SkillAction(0, 0);
                BattleManager.battleinstance.isPlayerattack = false;
            }
        }
    }
    /// <summary>
    /// 使用するポーションのナンバーを渡す
    /// </summary>
    private void EffectPortion(int portionnumber){
        PortionManager.portioninstance.UsedPortion(portionnumber);
    }
}
