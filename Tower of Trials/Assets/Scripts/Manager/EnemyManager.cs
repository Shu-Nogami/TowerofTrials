using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public static EnemyManager enemyinstance;
    [SerializeField] private List<GameObject> enemyList = new List<GameObject>();
    private void Awake(){
        if(enemyinstance == null){
            enemyinstance = this;
            DontDestroyOnLoad(gameObject);
        }
        else{
            Destroy(gameObject);
        }
    }
}
