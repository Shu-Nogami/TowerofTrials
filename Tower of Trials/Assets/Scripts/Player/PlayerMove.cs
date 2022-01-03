using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private bool isMove = true;
    // 移動先の座標
    private Vector3 nextmovepotion;
    // x軸の移動距離
    private Vector3 xaxismove = new Vector3(1f, 0, 0);
    // z軸の移動距離
    private Vector3 zaxismove = new Vector3(0, 0, 1f);

    void Start()
    {
        
    }

    void Update()
    {
        if (isMove)
        {
            SetMovePotion();
        }
        move();
    }
    /// <summary>
    /// 入力された移動キーを読み取り、対応した軸で位置を計算する
    /// </summary>
    void SetMovePotion(){
        // 上方向
        if(Input.GetKeyDown(KeyCode.UpArrow)){
            nextmovepotion = transform.position + zaxismove;
        }
        // 下方向
        if(Input.GetKeyDown(KeyCode.DownArrow)){
            nextmovepotion = transform.position - zaxismove;
        }
        // 右方向
        if(Input.GetKeyDown(KeyCode.RightArrow)){
            nextmovepotion = transform.position + xaxismove;
        }
        // 左方向
        if(Input.GetKeyDown(KeyCode.LeftArrow)){
            nextmovepotion = transform.position - xaxismove;
        }
    }
    /// <summary>
    /// 現在の位置から目的の位置に移動する
    /// </summary>
    void move(){
        transform.position = Vector3.MoveTowards(transform.position, nextmovepotion, 3f);
    }
}
