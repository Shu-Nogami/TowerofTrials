using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortionStateValue
{
    private string portionName;
    private string portionText;
    private int portionCount;
    private int portionNumber;
    private int plushp;
    private int plusmana;
    public void SetPortionName(string name){
        portionName = name;
    }
    public void SetPortionText(string text){
        portionText = text;
    }
    public void SetPortionCount(int count){
        portionCount = count;
    }
    public void SetPortionNumber(int number){
        portionNumber = number;
    }
    /// <summary>
    /// 増加させる体力量を設定
    /// </summary>
    public void SetPlusHp(int plusvalue){
        plushp = plusvalue;
    }
    /// <summary>
    /// 増加させるマナ量を設定
    /// </summary>
    public void SetPlusMana(int plusvalue){
        plusmana = plusvalue;
    }
    public string GetPortionName(){
        return portionName;
    }
    public string GetPortionText(){
        return portionText;
    }
    public int GetPortionCount(){
        return portionCount;
    }
    public int GetPortionNumber(){
        return portionNumber;
    }    /// <summary>
    /// 増加させる体力量を渡す
    /// </summary>
    public int GetPlusHp(){
        return plushp;
    }
    /// <summary>
    /// 増加させるマナ量を渡す
    /// </summary>
    public int GetPlusMana(){
        return plusmana;
    }
    public void PlusCount(int plusCount){
        portionCount += plusCount;
    }
    public void CutCount(int cutCount){
        portionCount -= cutCount;
    }
}
