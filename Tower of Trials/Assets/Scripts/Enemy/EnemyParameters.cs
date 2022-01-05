using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyParameters : PawnParameters
{
    [SerializeField] PlayerParameters parameters;
    // Start is called before the first frame update
    void Start()
    {
        initialize();
    }

    // Update is called once per frame
    void Update()
    {
        parameters.AddDamage(1);
        parameters.AddXp(10);
    }
    protected override void initialize()
    {
        base.initialize();
    }
}
