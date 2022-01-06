using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarValue
{
    private int maxValue;
    private int nowValue;
    public void SetMaxValue(int setvalue){
        maxValue = setvalue;
    }
    public void SetNowValue(int setvalue){
        nowValue = setvalue;
    }
    public int GetMaxValue(){
        return maxValue;
    }
    public int GetNowValue(){
        return nowValue;
    }
    public void SetMaxNowValue(int setmaxvalue, int setnowvalue){
        maxValue = setmaxvalue;
        nowValue = setnowvalue;
    }
    /// <summary>
    /// 現在の値から受け取った値を足す
    /// </summary>
    public void AddNowValue(int addvalue){
        if(addvalue > 0){
            nowValue += addvalue;
            if(nowValue > maxValue) nowValue = maxValue;
        }
    }
    /// <summary>
    /// 現在の値から受け取った値を引く
    /// </summary>
    public void CutNowValue(int cutvalue){
        if(cutvalue > 0){
            nowValue -= cutvalue;
            if(nowValue < 0) nowValue = 0;
        }
    }
}
