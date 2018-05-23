using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class T_Scroll : MonoBehaviour
{
    /*======================================================================================
     *   T_Scrollは、背景スクロールするプログラムである。
     *   仕様シーンは、sceen、titleである。
     *======================================================================================*/

    public int MoveObj;//背景スクロール数を決める。


    public float move_scroll1;//背景スクロールのスピード
    public float move_scroll2;
    public float move_scroll3;



    public float[] scroll_speed = new float[5];//背景スクロールのスピード

//    public float[] pb;
//    pb = new float[5];



    public GameObject fab_obj1;//背景スクロールの画像
    public GameObject fab_obj2;
    public GameObject fab_obj3;
    public GameObject fab_obj4;
    public GameObject fab_obj5;
    public GameObject fab_obj6;

 //   private GameObject[] scroll_sheet = new GameObject[MoveObj];//背景スクロールのスピード


    [SerializeField]
    private float posheight1;//背景スクロールの画像の高さ
    private float posheight2;
    private float posheight3;

/*
    public static void Scroll()
    {
    public int MoveObj2;//背景スクロール数を決める。

    private float[] scroll_speed2 = new float[MoveObj2];//背景スクロールのスピード

    }
*/


/*
*/

// Use this for initialization
void Start()
    {


        
        //背景１のスクロール
        posheight1 = fab_obj1.GetComponent<SpriteRenderer>().bounds.size.y;//背景１の高さをGET
     //   pos1 = fab_obj2.transform.position;
        fab_obj1.transform.position = new Vector2(0, 0);//背景１の初期位置
        fab_obj2.transform.position = new Vector2(0, posheight1);//背景１の続きの初期位置

        //背景２のスクロール
        posheight2 = fab_obj3.GetComponent<SpriteRenderer>().bounds.size.y;//背景２の高さをGET
//        pos2 = fab_obj3.transform.position;
        fab_obj3.transform.position = new Vector2(0, 0);//背景２の初期位置
        fab_obj4.transform.position = new Vector2(0, posheight2);//背景２の続きの初期位置

        //背景３のスクロール
        posheight3 = fab_obj5.GetComponent<SpriteRenderer>().bounds.size.y;//背景３の高さをGET
//        pos3 = fab_obj5.transform.position;
        fab_obj5.transform.position = new Vector2(0, 0);//背景３の初期位置
        fab_obj6.transform.position = new Vector2(0, posheight3);//背景３の続きの初期位置

    }

    // Update is called once per frame
    void Update()
    {
        /*=====背景１の移動量設定====================================================================================================*/
        fab_obj1.transform.Translate(0, move_scroll1, 0);//背景１の移動
        fab_obj2.transform.Translate(0, move_scroll1, 0);//背景１の続きの移動

        if ( fab_obj1.transform.position.y <= -1 * posheight1 )//背景１の高さ分移動したら背景１は、元の位置に
        {
             fab_obj1.transform.position = new Vector2(0, 0);
        }
        if ( fab_obj2.transform.position.y <= 0 )//背景１の続きの高さ分移動したら背景１の続きは、元の位置に
        {
             fab_obj2.transform.position = new Vector2(0, posheight1);
        }



        /*=====背景２の移動量設定====================================================================================================*/
        fab_obj3.transform.Translate(0, move_scroll2, 0);//背景２の移動
        fab_obj4.transform.Translate(0, move_scroll2, 0);//背景２の続きの移動

        if (fab_obj3.transform.position.y <= -1 * posheight2)//背景２の高さ分移動したら背景１は、元の位置に
        {
            fab_obj3.transform.position = new Vector2(0, 0);
        }
        if (fab_obj4.transform.position.y <= 0)//背景１の続きの高さ分移動したら背景２の続きは、元の位置に
        {
            fab_obj4.transform.position = new Vector2(0, posheight2);
        }

        /*=====背景３の移動量設定====================================================================================================*/
        fab_obj5.transform.Translate(0, move_scroll3, 0);//背景３の移動
        fab_obj6.transform.Translate(0, move_scroll3, 0);//背景３の続きの移動

        if (fab_obj5.transform.position.y <= -1 * posheight3)//背景３の高さ分移動したら背景３は、元の位置に
        {
            fab_obj5.transform.position = new Vector2(0, 0);
        }
        if (fab_obj6.transform.position.y <= 0)//背景３の続きの高さ分移動したら背景３の続きは、元の位置に
        {
            fab_obj6.transform.position = new Vector2(0, posheight3);
        }

    }


}
