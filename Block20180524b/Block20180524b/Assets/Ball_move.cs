using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using System;

public class Ball_move : MonoBehaviour
{
    /*======================================================================================
     *   Ball_moveは、１．void Start()時のブロックの生成
     *                ２．void Update()時のボールの移動処理
     *                ３．void OnCollisionEnter2D(Collision2D c)のボールの反射処理を行っている。
     *   仕様シーンは、titleである。
     *======================================================================================*/







    public float distancePerFrame;       //ボールの     移動スピード
    public float paddlePostion;          //パドルの位置
    public int x_dir = -1;               //ボールのX方向フラグ
    public int y_dir = -1;               //ボールのY方向フラグ
//    public GameObject T_obj;             //＊過去の物　タイルオブジェクト
    public GameObject ball;              //ボールのGameObjec
    private GameObject[,] Block_obj;     //ブロックのGameObject配列
    public int point;                    //GameScoreクラスに継承される　GameScoreクラスの変数scoreに代入される。
                                         //    public Vector2 pos;                  //
                                         /*画面３重スクロール前の変数と思われる。
                                             public float flap = 550f;
                                             public float scroll = 10f;
                                         */
                                         //ボールになる前に使っていた。3D Objectの時
                                         //Rigidbody2D rb2d;
                                         //
    public GameObject[] obj;             //
    // Use this for initialization
    void Start()
    {
        /*==========================================================
         * １．void Start()時のブロックの生成
         *==========================================================*/


        List<GameObject[]> Block_obj = new List<GameObject[]>();

        for (int i = 0; i < 5; i++)
        {
            obj = new GameObject[3];
            for (int j = 0; j < 3; j++)
            {
                obj[j] = Instantiate(Resources.Load("Block_pref2"), new Vector2(-1.5f + (1.5f * j), 3.0f - (0.645f * i)), Quaternion.identity) as GameObject;
            }
            Block_obj.Add(obj);

        }
        x_dir = -1;
        y_dir = -1;
        point = 0;



}


    void Update()
    {
        /*==========================================================
         * ２．ボールの移動処理
         *==========================================================*/
        transform.Translate(x_dir * distancePerFrame, y_dir * distancePerFrame, 0);

        //rb2d.velocity = new Vector2(scroll * x_dir, rb2d.velocity.y);
    }


    /*==========================================================
     * ３．ボールの反射処理
     *==========================================================*/

    //    void OnTriggerEnter2D(Collider2D c)
    void OnCollisionEnter2D(Collision2D c)
    {
        string tag = c.gameObject.tag;
//        Debug.Log("0:hit filed: " + c.gameObject.tag);

        if (tag == "yoko_filed")
        {
            x_dir = x_dir * -1;
                        Debug.Log("hit Object  COLLISION");
                        Debug.Log("1:hit filed: " + c.gameObject.tag);
        }
        if (tag == "filed")
        {
            y_dir = y_dir * -1;
                        Debug.Log("hit Object  COLLISION");
                        Debug.Log("1:hit filed: " + c.gameObject.tag );
        }
        if (tag == "block")
        {
            y_dir = y_dir * -1;

            point = point + 100;
            distancePerFrame = distancePerFrame + 0.01f;
        }
            return;

    }
}


/*======================================================================================
 *   OLD   OnTriggerEnterを使用していた。
 *
  ====================================================================================*/

/*
    void OnTriggerEnter(Collider c)
    {
    if (c.gameObject.tag == "yoko_filed")
        {
            x_dir = x_dir * -1;
//            Debug.Log("hit Object  COLLISION");
//            Debug.Log("1:hit filed: " + c.gameObject.tag);
        }
        if (c.gameObject.tag == "filed")
        {
            y_dir = y_dir * -1;
//            Debug.Log("hit Object  COLLISION");
//            Debug.Log("1:hit filed: " + c.gameObject.tag );
        }
        if (c.gameObject.tag == "block")
        {
            y_dir = y_dir * -1;
            
            point = point + 100;
            distancePerFrame = distancePerFrame + 0.01f;
//            Destroy(T_obj);
            //            Debug.Log("hit Object  COLLISION");
            //            Debug.Log("1:hit filed: " + c.gameObject.tag );
        }


        return;
    }
    */
