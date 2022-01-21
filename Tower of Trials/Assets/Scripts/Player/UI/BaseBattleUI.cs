using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BaseBattleUI : MonoBehaviour
{
    [SerializeField] protected Slider playerHpBar;
    [SerializeField] protected Slider playerManaBar;
    [SerializeField] protected GameObject battleCanvas;
    public void SetPlayerHPBar(int playerMaxHp, int playerNowHp){
        playerHpBar.maxValue = playerMaxHp;
        playerHpBar.value = playerNowHp;
    }
    public void SetPlayerManaBar(int playerMaxMana, int playerNowMana){
        playerManaBar.maxValue = playerMaxMana;
        playerManaBar.value = playerNowMana;
    }
    public GameObject GetThisObj(){
        return battleCanvas;
    }
}
