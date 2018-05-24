using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class T_Scroll : MonoBehaviour
{
    /*======================================================================================
     *   T_Scrollは、背景スクロールするプログラムである。
     *   仕様シーンは、sceen、titleである。
     *======================================================================================*/




    public  float[] scroll_speed = new float[3];       //背景スクロールのスピード
    private float[] Obj_height = new float[3];         //背景スクロールの画像の高さ
    public  GameObject[] Obj_img_1 = new GameObject[3];//背景スクロールの画像上
    public  GameObject[] Obj_img_2 = new GameObject[3];//背景スクロールの画像下
    public int[] Mov_Dir = new int[3];                //背景スクロールの方向     
    public int[] Obj_deps = new int[3];               //背景スクロールの深さ     


    // Use this for initialization
    void Start()
    {

        Func_scroll(3);
    }

//  初期値
    void Func_scroll(int M_obj_num)
    {

        for (int i = 0; i < M_obj_num; i++)
        {
            Obj_height[i] = Obj_img_1[i].GetComponent<SpriteRenderer>().bounds.size.y;//背景１の高さをGET
            Obj_img_1[i].transform.position = new Vector2(0, 0);//背景１の初期位置
            Obj_img_2[i].transform.position = new Vector2(0, Obj_height[i]);//背景１の続きの初期位置
        }
    }




    // Update is called once per frame
    void Update()
    {
        /*=====背景１の移動量設定====================================================================================================*/
    /*    fab_obj1.transform.Translate(0, move_scroll1, 0);//背景１の移動
        fab_obj2.transform.Translate(0, move_scroll1, 0);//背景１の続きの移動

        if ( fab_obj1.transform.position.y <= -1 * posheight1 )//背景１の高さ分移動したら背景１は、元の位置に
        {
             fab_obj1.transform.position = new Vector2(0, 0);
        }
        if ( fab_obj2.transform.position.y <= 0 )//背景１の続きの高さ分移動したら背景１の続きは、元の位置に
        {
             fab_obj2.transform.position = new Vector2(0, posheight1);
        }*/



        /*=====背景２の移動量設定====================================================================================================*/
     /*   fab_obj3.transform.Translate(0, move_scroll2, 0);//背景２の移動
        fab_obj4.transform.Translate(0, move_scroll2, 0);//背景２の続きの移動

        if (fab_obj3.transform.position.y <= -1 * posheight2)//背景２の高さ分移動したら背景１は、元の位置に
        {
            fab_obj3.transform.position = new Vector2(0, 0);
        }
        if (fab_obj4.transform.position.y <= 0)//背景１の続きの高さ分移動したら背景２の続きは、元の位置に
        {
            fab_obj4.transform.position = new Vector2(0, posheight2);
        }*/

        /*=====背景３の移動量設定====================================================================================================*/
     /*   fab_obj5.transform.Translate(0, move_scroll3, 0);//背景３の移動
        fab_obj6.transform.Translate(0, move_scroll3, 0);//背景３の続きの移動

        if (fab_obj5.transform.position.y <= -1 * posheight3)//背景３の高さ分移動したら背景３は、元の位置に
        {
            fab_obj5.transform.position = new Vector2(0, 0);
        }
        if (fab_obj6.transform.position.y <= 0)//背景３の続きの高さ分移動したら背景３の続きは、元の位置に
        {
            fab_obj6.transform.position = new Vector2(0, posheight3);
        }*/   

    }






}
