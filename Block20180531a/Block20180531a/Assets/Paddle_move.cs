using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using System;

public class Paddle_move : MonoBehaviour
{
    /*======================================================================================
     *
     *   Paddle_moveは、スクリーン座標をワールド座標に変換するプログラムである。
     *                  マウスのポジションをパドルのポジションに変換する。
     *
     *======================================================================================*/

    //位置変換
    public float PanelFrame;
    public Vector2 mousePosition;
    public GameObject particle;
    // 位置座標
    private Vector3 position;
    // スクリーン座標をワールド座標に変換した位置座標
    [SerializeField]
    private Vector3 screenToWorldPointPosition;

    //位置変換
    //パドルの移動量MAX
    public float MaXLeft = new float();
    public float MaXRight = new float();

/*    public GameObject tmpRightWall = new GameObject();
    public GameObject tmpLeftWall = new GameObject();
    public GameObject tmpTopWall = new GameObject();
    public GameObject tmpZiki = new GameObject();*/
    public GameObject tmpRightWall;
    public GameObject tmpLeftWall;
    public GameObject tmpTopWall;
    public GameObject tmpZiki;
    public float LeftWallWidth = new float();
    public float RightWallWidth = new float();
    public GameObject Ziki;
    public float ZikiPosition;
    public Vector3 tmptmpZiki;
    public float test_point;
    public float RightWallPosittion = new float();
    public float LeftWallPosittion = new float();
    public float ZikiWidth = new float();



    void Start()
    {

//        GameObject tmpRightWall = new GameObject();
//        GameObject tmpLeftWall = new GameObject();
//        GameObject tmpTopWall = new GameObject();
//        GameObject tmpZiki = new GameObject();






    //壁の初期値
    //    [SerializeField]//[System.Serializable]
    GameObject tmpRightWall = GameObject.Find("/Walls/Right_wall");
        tmpRightWall.transform.position = new Vector2(2.5f, -0.75f);

        GameObject tmpLeftWall = GameObject.Find("/Walls/Left_wall");
        tmpLeftWall.transform.position = new Vector2(-2.5f, -0.75f);

        GameObject tmpTopWall = GameObject.Find("/Walls/Top_wall");
        tmpTopWall.transform.position = new Vector2(0.0f, 3.5f);

        GameObject tmpZiki = GameObject.Find("ziki");
        tmpZiki.transform.position = new Vector2(0.0f, 0.0f);
    }

    void Update()
    {
        position = Input.mousePosition;
        // Z軸修正
        position.z = 10.0f;
        // Y軸修正
        // position.y = 30.0f;
        position.y = 30.0f;

        LeftWallWidth = GameObject.Find("Left_wall").GetComponent<SpriteRenderer>().bounds.size.x;
        RightWallWidth = GameObject.Find("Right_wall").GetComponent<SpriteRenderer>().bounds.size.x;



        //    GameObject.Find("hogehoge").transform.position = new Vector2(tmp.x + 100, tmp.y, tmp.z);
        LeftWallPosittion = GameObject.Find("Left_wall").transform.position.x;
        RightWallPosittion = GameObject.Find("Right_wall").transform.position.x;

        ZikiWidth = GameObject.Find("ziki").GetComponent<SpriteRenderer>().bounds.size.x;

        //LeftWallWidth = GameObject.Find("Left_wall").transform.position.y;
        MaXLeft = LeftWallPosittion + ZikiWidth;//; + ( LeftWallWidth / 2 );
        //             -2.5           1.465         0.32/2   :-1.56
        MaXRight = RightWallPosittion + (-1* ZikiWidth*2) + (RightWallWidth / 2);
        //             2.5           -1.465         0.32/2   :0.269

        ZikiPosition = position.x;


 
        // マウス位置座標をスクリーン座標からワールド座標に変換する
        screenToWorldPointPosition = Camera.main.ScreenToWorldPoint(position);
        // ワールド座標に変換されたマウス座標を代入
        //gameObject.transform.position = screenToWorldPointPosition;

        //
        GameObject.Find("ziki").transform.position = screenToWorldPointPosition;
        test_point = GameObject.Find("ziki").transform.position.x;

        //tmptmpZiki = screenToWorldPointPosition;
        //Ziki.transform.position = tmptmpZiki;
        if (test_point <= MaXLeft)
        //                    -1.035
        //          if (position.x <= 280)
        {
            //            ZikiPosition = screenToWorldPointPosition.x;
            //            screenToWorldPointPosition.x = MaXLeft;
            position.x = MaXLeft;
            Debug.Log("test_point:" + test_point);

        }
        else if (GameObject.Find("ziki").transform.position.x >= MaXRight)
        //          if (position.x >= 80)
        {
            position.x = position.x;
        }
        else
        {
            ZikiPosition = Ziki.transform.position.x;
        }
        Debug.Log("Ziki.transform.position.x : " + Ziki.transform.position.x);
    }
    private int FuncZikiR(float CurrentPossion,float MaxPossion)
    {
        if(CurrentPossion >= MaxPossion)
        {
            return 1;
        }
        else
        {
            return 0;
        }
    }
}
