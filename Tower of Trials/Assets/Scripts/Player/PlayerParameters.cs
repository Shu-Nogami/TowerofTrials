using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerParameters : PawnParameters, IDamage, IPlusXp
{
    // Start is called before the first frame update
    void Start()
    {
        initialize();
    }

    // Update is called once per frame
    void Update()
    {
        if(hpValue.GetNowValue() == 0){
            Dead();
        }
        Debug.Log(hpValue.GetNowValue());
        Debug.Log(xpValue.GetNowValue());
    }
    protected override void initialize()
    {
        hpValue.SetMaxNowValue(500, 3);
        xpValue.SetMaxNowValue(500, 0);
        manaValue.SetMaxNowValue(100, 100);
        level = 1;
        attackdamage = 100;
        critical = 0;
        defense = 100;
        money = 0;
    }
    protected override void Dead()
    {
        Debug.Log("PlayerDead");
    }
    public void AddDamage(int damage){
        hpValue.CutNowValue(damage);
    }
    public void AddXp(int plusxp){
        xpValue.AddNowValue(plusxp);
    }
}
