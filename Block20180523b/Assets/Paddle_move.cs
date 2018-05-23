using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Paddle_move : MonoBehaviour
{
    /*======================================================================================
     *
     *   Paddle_moveは、スクリーン座標をワールド座標に変換するプログラムである。
     *                  マウスのポジションをパドルのポジションに変換する。
     *
     *======================================================================================*/



    public float PanelFrame;
    public Vector2 mousePosition;
    public GameObject particle;
     // 位置座標
    private Vector3 position;
    // スクリーン座標をワールド座標に変換した位置座標
    private Vector3 screenToWorldPointPosition;
    void Start()
    {
    }

    void Update()
    {
		position = Input.mousePosition;
        // Z軸修正
        position.z = 10f;
        // Y軸修正
        position.y = 30.0f;

        if (position.x <= 185.0f)
        {
            position.x = 185.0f;
        }

        if (position.x >= 260.0f)
        {
            position.x = 260.0f;
        }
        // マウス位置座標をスクリーン座標からワールド座標に変換する
        screenToWorldPointPosition = Camera.main.ScreenToWorldPoint(position);
		// ワールド座標に変換されたマウス座標を代入
		gameObject.transform.position = screenToWorldPointPosition;
        //Debug.Log("position.x : " + position.x)
;
    }

}
