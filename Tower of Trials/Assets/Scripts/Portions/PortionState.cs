using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortionState
{
    private int portionnumber;
    private int portionACnumber;
    private string portionprocess;
    /// <summary>
    /// ポーションのナンバー、増減数、処理内容を登録する
    /// </summary>
    public void SetPortionState(int number, int acnumber, string process){
        portionnumber = number;
        portionACnumber = acnumber;
        portionprocess = process;
    }
    /// <summary>
    /// ポーションのナンバーを返す
    /// </summary>
    public int GetPortionNumber(){
        return portionnumber;
    }
    /// <summary>
    /// ポーションの増減数を返す
    /// </summary>
    public int GetPortionACNumber(){
        return portionACnumber;
    }
    /// <summary>
    /// ポーションの処理内容を返す
    /// </summary>
    public string GetPortionProcess(){
        return portionprocess;
    }
}