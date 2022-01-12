using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemStateValue
{
    private string itemName;
    private int itemDefence;
    private int itemAttackDamage;
    private int itemCritical;
    public void SetItemName(string name){
        itemName = name;
    }
    public void SetItemDefence(int defence){
        itemDefence = defence;
    }
    public void SetItemAttackDamage(int damage){
        itemAttackDamage = damage;
    }
    public void SetItemCritical(int critical){
        itemCritical = critical;
    }
    public string GetItemName(){
        return itemName;
    }
    public int GetItemDefence(){
        return itemDefence;
    }
    public int GetItemAttckDamage(){
        return itemAttackDamage;
    }
    public int GetItemCritical(){
        return itemCritical;
    }
}
