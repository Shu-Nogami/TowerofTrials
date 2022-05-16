using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public static EnemyManager enemyinstance { get; private set; }
    [SerializeField] private List<GameObject> enemyList = new List<GameObject>();
    private EnemyEncounterList encounterList;
    private List<int> spawnEnemyNums = new List<int>();
    private int minSpawnEnemy = 1;
    private int maxSpawnEnemy = 3;
    private void Awake(){
        if(enemyinstance == null){
            enemyinstance = this;
            DontDestroyOnLoad(gameObject);
        }
        else{
            Destroy(gameObject);
        }
        this.Initialize();
    }
    public void Initialize(){
        this.minSpawnEnemy = 1;
        this.maxSpawnEnemy = 3;
        encounterList = new EnemyEncounterList();
    }
    public void SpawnEnemy(){
        this.spawnEnemyNums.AddRange(encounterList.GetEncounterList());
        for(int i = 0;i < Random.Range(minSpawnEnemy, maxSpawnEnemy + 1);i++){
            Instantiate(enemyList[spawnEnemyNums[Random.Range(0, spawnEnemyNums.Count)]]);
        }
    }
}
