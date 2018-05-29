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
    private float MaXLeft = new float();
    private float MaXRight = new float();
    private float LeftWallThickness = new float();
    private float RightWallThickness = new float();
    private GameObject tmpRightWall = new GameObject();
    private GameObject tmpLeftWall = new GameObject();
    private float RightWallPosittion = new float();
    private float LeftWallPosittion = new float();
    private float ZikiThickness = new float();


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


        tmpRightWall = GameObject.Find("Left_wall");
        tmpLeftWall = GameObject.Find("Right_wall");

        LeftWallThickness  = tmpLeftWall.GetComponent<SpriteRenderer>().bounds.size.y;
        RightWallThickness = tmpRightWall.GetComponent<SpriteRenderer>().bounds.size.y;





        //    GameObject.Find("hogehoge").transform.position = new Vector2(tmp.x + 100, tmp.y, tmp.z);

        LeftWallPosittion = GameObject.Find("Left_wall").transform.position.y;
        RightWallPosittion = GameObject.Find("Right_wall").transform.position.y;
        ZikiThickness = GameObject.Find("ziki").transform.position.y;

        //LeftWallThickness = GameObject.Find("Left_wall").transform.position.y;
        MaXLeft = LeftWallPosittion + ZikiThickness;

        MaXRight = RightWallPosittion - ZikiThickness;

        if (position.x <= MaXLeft)
        {
            position.x = MaXLeft;
        }

        if (position.x >= MaXRight)
        {
            position.x = MaXRight;
        }
        // マウス位置座標をスクリーン座標からワールド座標に変換する
        screenToWorldPointPosition = Camera.main.ScreenToWorldPoint(position);
		// ワールド座標に変換されたマウス座標を代入
		gameObject.transform.position = screenToWorldPointPosition;
        //Debug.Log("position.x : " + position.x);
    }

}
