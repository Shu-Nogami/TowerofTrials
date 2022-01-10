using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LowHealPortion : PortionParameters
{
    protected override void Start(){
        PortionInitialize();
        base.Start();
    }
    protected override void PortionInitialize()
    {
        base.PortionInitialize();
        portionname = "下級回復ポーション";
        plusvalues.SetPlusHp(300);
        count = 3;
        portionnumber = 0;
    }
}