using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerBattleEnemyViewUI : BaseBattleUI
{
    [SerializeField] List<Image> viewEnemyImages = new List<Image>();
    public void SetEnemyImages(List<Image> enemyImages){
        foreach(Image viewImages in viewEnemyImages){
            viewImages.enabled = true;
        }
        switch(BattleManager.battleinstance.GetEnemyListCount()){
            case 1:
                viewEnemyImages[0].enabled = false;
                viewEnemyImages[1].sprite = enemyImages[0].sprite;
                viewEnemyImages[2].enabled = false;
                break;
            case 2:
                viewEnemyImages[0].sprite = enemyImages[0].sprite;
                viewEnemyImages[1].enabled = false;
                viewEnemyImages[2].sprite = enemyImages[1].sprite;
                break;
            case 3:
                viewEnemyImages[0].sprite = enemyImages[0].sprite;
                viewEnemyImages[1].sprite = enemyImages[1].sprite;
                viewEnemyImages[2].sprite = enemyImages[2].sprite;
                break;
            default:
                break;
        }
    }
}
