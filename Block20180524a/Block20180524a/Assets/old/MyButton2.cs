using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyButton2 : MonoBehaviour {


    public void OnClick()
    {
        Debug.Log("Button click!");
        // 非表示にする
        gameObject.SetActive(false);
    }
}
