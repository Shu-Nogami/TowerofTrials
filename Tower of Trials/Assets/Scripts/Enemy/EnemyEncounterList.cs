using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyEncounterList
{
    private List<int> encounterNumList = new List<int>();
    public List<int> GetEncounterList(){
        encounterNumList.Clear();
        switch(GameManager.gameInstance.GetFloorNum()){
            case 1:
                this.encounterNumList.Add(0);
                break;
            case 2:
                break;
            case 3:
                break;
            case 4:
                break;
            case 5:
                break;
            default:
                break;
        }
        return encounterNumList;
    }
}
