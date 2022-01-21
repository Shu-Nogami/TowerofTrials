using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerBattleTargetUI : BaseBattleUI
{
    private int enemyListCount;
    [SerializeField] private List<GameObject> enemyButtonList = new List<GameObject>();
    [SerializeField] private List<TextMeshProUGUI> enemyNameList = new List<TextMeshProUGUI>();
    public void UpdateEnemyButton(List<GameObject> enemyList){
        for(enemyListCount = 0;enemyListCount < enemyList.Count;enemyListCount++){
            enemyButtonList[enemyListCount].SetActive(true);
            enemyNameList[enemyListCount].text = enemyList[enemyListCount].GetComponent<EnemyParameters>().GetEnemyName();
        }
        for(;enemyListCount < enemyButtonList.Count;enemyListCount++){
            enemyButtonList[enemyListCount].SetActive(false);
        }
    }
}
