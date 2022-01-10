using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using System;

public class PortionParameters : MonoBehaviour
{
    protected string portionname;
    protected PlusParameters plusvalues = new PlusParameters();
    protected int count;
    protected int portionnumber;
    protected virtual void Start(){
        PortionManager.portioninstance.PortionNumberChanged.Where(State => State.GetPortionNumber() == portionnumber && State.GetPortionProcess() == "ADD")
                                                           .Subscribe(State => AddPortionNumber(State.GetPortionACNumber()));
        PortionManager.portioninstance.PortionNumberChanged.Where(State => State.GetPortionNumber() == portionnumber && State.GetPortionProcess() == "USE")
                                                           .Subscribe(State => { ConsumePortion(State.GetPortionACNumber()); });
        Destroy(gameObject);
    }
    /// <summary>
    /// ポーションの内容初期化
    /// </summary>
    protected virtual void PortionInitialize(){
        portionname = "";
        plusvalues.SetPlusHp(0);
        plusvalues.SetPlusMana(0);
        count = 0;
        portionnumber = 999;
    }
    /// <summary>
    /// ポーションの個数を指定数増やす
    /// </summary>
    protected virtual void AddPortionNumber(int addcount){
        count += addcount;
    }
    /// <summary>
    /// ポーションの個数を指定数減らす
    /// </summary>
    protected virtual void CutPortionNumber(int cutcount){
        count -= cutcount;
        if(count < 0) count = 0;
    }
    /// <summary>
    /// ポーションを使用し、効果内容を渡す
    /// </summary>
    private void ConsumePortion(int cutcount){
        CutPortionNumber(cutcount);
        PortionManager.portioninstance.PassPortionState(plusvalues);
    }
}