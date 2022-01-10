using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlusParameters
{
    private int plushp = 0;
    private int plusmana = 0;
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
    /// <summary>
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
}