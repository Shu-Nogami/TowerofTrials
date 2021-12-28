using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private bool ismove = true;
    private Vector3 nextmovepotion;
    private Vector3 xaxismove = new Vector3(1f, 0, 0);
    private Vector3 zaxismove = new Vector3(0, 0, 1f);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ismove)
        {
            SetMovePotion();
        }
        move();
    }
    void SetMovePotion(){
        if(Input.GetKeyDown(KeyCode.UpArrow)){
            nextmovepotion = transform.position + zaxismove;
        }
        if(Input.GetKeyDown(KeyCode.DownArrow)){
            nextmovepotion = transform.position - zaxismove;
        }
        if(Input.GetKeyDown(KeyCode.RightArrow)){
            nextmovepotion = transform.position + xaxismove;
        }
        if(Input.GetKeyDown(KeyCode.LeftArrow)){
            nextmovepotion = transform.position - xaxismove;
        }
    }
    void move(){
        transform.position = Vector3.MoveTowards(transform.position, nextmovepotion, 3f);
    }
}
