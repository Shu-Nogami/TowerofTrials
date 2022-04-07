using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using System;

public class PortionParameters : MonoBehaviour
{
    protected PortionStateValue portionValues = new PortionStateValue();
    protected virtual void Start(){

    }
    /// <summary>
    /// ポーションの内容初期化
    /// </summary>
    protected virtual void PortionInitialize(){
        portionValues.SetPortionName("");
        portionValues.SetPortionText("testText");
        portionValues.SetPortionCount(0);
        portionValues.SetPortionNumber(999);
        portionValues.SetPlusHp(0);
        portionValues.SetPlusMana(0);
    }
    /// <summary>
    /// ポーションの個数を指定数増やす
    /// </summary>
    public void AddPortionNumber(int addCount){
        portionValues.PlusCount(addCount);
    }
    /// <summary>
    /// ポーションの個数を指定数減らす
    /// </summary>
    private void CutPortionNumber(int cutCount){
        portionValues.CutCount(cutCount);
    }
    /// <summary>
    /// ポーションを使用し、効果内容を渡す
    /// </summary>
    public void ConsumePortion(int cutcount){
        CutPortionNumber(cutcount);
        PortionManager.portioninstance.PassPortionState(portionValues);
    }
}