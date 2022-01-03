using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyParameters : PawnParameters
{
    // Start is called before the first frame update
    void Start()
    {
        initialize();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(hpValue.GetNowValue());
    }
    protected override void initialize()
    {
        base.initialize();
    }
}
