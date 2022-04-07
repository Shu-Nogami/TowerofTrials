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
        portionValues.SetPortionName("lowPortion");
        portionValues.SetPortionText("test");
        portionValues.SetPlusHp(300);
        portionValues.SetPortionCount(3);
        portionValues.SetPortionNumber(0);
    }
}