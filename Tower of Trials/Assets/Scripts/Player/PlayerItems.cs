using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerItems : MonoBehaviour
{
    private ItemStateValue weaponState = new ItemStateValue();
    private ItemStateValue armourState = new ItemStateValue();
    public void SetWeaponState(string name, int damage, int defence, int critical){
        weaponState.SetItemName(name);
        weaponState.SetItemAttackDamage(damage);
        weaponState.SetItemDefence(defence);
        weaponState.SetItemCritical(critical);
    }
    public void SetArmourState(string name, int damage, int defence, int critical){
        armourState.SetItemName(name);
        armourState.SetItemAttackDamage(damage);
        armourState.SetItemDefence(defence);
        armourState.SetItemCritical(critical);
    }
    public string GetWeaponName(){
        return weaponState.GetItemName();
    }
    public string GetArmourName(){
        return armourState.GetItemName();
    }
    public int GetItemsAttackDamage(){
        return weaponState.GetItemAttckDamage() + armourState.GetItemAttckDamage();
    }
    public int GetItemsDefence(){
        return weaponState.GetItemDefence() + armourState.GetItemDefence();
    }
    public int GetItemsCritical(){
        return weaponState.GetItemCritical() + armourState.GetItemCritical();
    }
}