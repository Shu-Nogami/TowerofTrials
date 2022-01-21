using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BaseButtonAction : MonoBehaviour
{
    public virtual void Click(){
        Debug.Log("This button clicked!");
    }
}
