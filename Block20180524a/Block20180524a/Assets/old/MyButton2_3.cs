using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyButton2_3 : MonoBehaviour {

    public void OnClick()
    {
        Debug.Log("Button click!");
        // 非表示にする
        gameObject.SetActive(false);
        // Button2を表示する（※ここを追加）
        MyCanvas.SetActive("Button2", true);
    }
}
