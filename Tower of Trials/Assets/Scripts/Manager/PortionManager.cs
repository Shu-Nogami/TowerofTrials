using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using System;

public class PortionManager : MonoBehaviour
{
    public static PortionManager portioninstance;
    [SerializeField] List<PortionParameters> portions = new List<PortionParameters>();
    private List<PortionStateValue> havingpotions = new List<PortionStateValue>();
    private Subject<PortionState> portionsubject = new Subject<PortionState>();
    PortionState portionState = new PortionState();
    [SerializeField] PlayerParameters Pparameters;
    GameObject portion;
    public IObservable<PortionState> PortionNumberChanged{
        get { return portionsubject; }
    }
    private void Awake(){
        if(portioninstance == null){
            portioninstance = this;
            DontDestroyOnLoad(gameObject);
        }
        else{
            Destroy(gameObject);
        }
    }
    /// <summary>
    /// ポーションの個数を追加
    /// </summary>
    public void AddPortion(int portionnumber){
        portions[portionnumber].AddPortionNumber(1);
    }
    /// <summary>
    /// ポーションを使用
    /// </summary>
    public void UsedPortion(int portionnumber){
        portions[portionnumber].ConsumePortion(1);
    }
    /// <summary>
    /// ポーションの効果をプレイヤーに渡す
    /// </summary>
    public void PassPortionState(PortionStateValue portionValues){
        Pparameters.EffectPortion(portionValues);
    }
    /// <summary>
    /// ポーションの識別番号を渡す
    /// </summary>
    public int GetPortionNumber(){
        return havingpotions.Count;
    }
}