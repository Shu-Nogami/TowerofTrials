using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using System;

public class PortionManager : MonoBehaviour
{
    public static PortionManager portioninstance;
    [SerializeField] List<GameObject> portions = new List<GameObject>();
    private List<GameObject> havingpotions = new List<GameObject>();
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
        havingpotions.Add(portions[0]);
        portion = (GameObject)Instantiate(portions[0]);
        portions.Sort();
    }
    /// <summary>
    /// ポーションの個数を追加
    /// </summary>
    public void AddPortion(int portionnumber){
        if(havingpotions.Contains(portions[portionnumber])){
            portionState.SetPortionState(portionnumber, 1, "ADD");
            portionsubject.OnNext(portionState);
        }
        else{
            havingpotions.Add(portions[portionnumber]);
            portion = (GameObject)Instantiate(portions[portionnumber]);
            havingpotions.Sort();
        }
    }
    /// <summary>
    /// ポーションを使用
    /// </summary>
    public void UsedPortion(int portionnumber){
        if(havingpotions.Contains(portions[portionnumber])){
            portionState.SetPortionState(portionnumber, 1, "USE");
            portionsubject.OnNext(portionState);
        }
    }
    /// <summary>
    /// ポーションの効果をプレイヤーに渡す
    /// </summary>
    public void PassPortionState(PlusParameters plusvalue){
        Pparameters.EffectPortion(plusvalue);
    }
}