using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager gameInstance { get; private set; }
    private int FloorNum = 1;
    private void Awake(){
        if(gameInstance == null){
            gameInstance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else{
            Destroy(this.gameObject);
        }
        this.Initialize();
    }
    public void Initialize(){
        FloorNum = 1;
    }
    public int GetFloorNum(){
        return FloorNum;
    }
}
