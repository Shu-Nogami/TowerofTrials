using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerBattleUI : MonoBehaviour
{
    [SerializeField] private Slider playerPickHpBar;
    [SerializeField] private Slider playerPickManaBar;
    [SerializeField] private Slider playerTargetHpBar;
    [SerializeField] private Slider playerTargetManaBar;
    [SerializeField] private Canvas playerPickCanvas;
    [SerializeField] private Canvas playerTargetCanvas;
    public void SetPlayerHPBar(int playerMaxHp, int playerNowHp){
        playerPickHpBar.maxValue = playerMaxHp;
        playerPickHpBar.value = playerNowHp;
        playerTargetHpBar.maxValue = playerMaxHp;
        playerTargetHpBar.value = playerNowHp;
    }
    public void SetPlayerManaBar(int playerMaxMana, int playerNowMana){
        playerPickManaBar.maxValue = playerMaxMana;
        playerPickManaBar.value = playerNowMana;
        playerTargetManaBar.maxValue = playerMaxMana;
        playerTargetManaBar.value = playerNowMana;
    }
}
