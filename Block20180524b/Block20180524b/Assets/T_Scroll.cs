using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class T_Scroll : MonoBehaviour
{
    /*======================================================================================
     *   T_Scrollは、背景スクロールするプログラムである。
     *   仕様シーンは、sceen、titleである。
     *======================================================================================*/
    /*
        List<GameObject[]> Block_obj = new List<GameObject[]>();

    for (int i = 0; i< 5; i++)
    {
        obj=new GameObject[3];
        for (int j = 0; j< 3; j++)
        {
            obj[j] = Instantiate(Resources.Load("Block_pref"), new Vector2(-1.5f + (1.5f * j),3.0f - (0.645f * i)), Quaternion.identity) as GameObject;
        }
    Block_obj.Add(obj);

    }
    */
    public int num;                                         //背景スクロールの数
    public int tmp_num;                                         //背景スクロールの数
    List<int> scroll_obj = new List<int>();                 //背景スクロールの数
    List<int[]> scroll_dir = new List<int[]>();             //背景スクロールの方向
    List<float[]> scroll_speed = new List<float[]>();       //背景スクロールのスピード
    List<float[]> Obj_height = new List<float[]>();         //背景スクロールの画像の高さ
    List<GameObject[]> Obj_img_1 = new List<GameObject[]>();//背景スクロールの画像上
    List<GameObject[]> Obj_img_2 = new List<GameObject[]>();//背景スクロールの画像下
    List<float[]> Obj_order_lay = new List<float[]>();         //背景スクロールの画像の高さ



    // Use this for initialization
    void Start()
    {

        scroll_obj.Add(num);
        tmp_num= scroll_obj[0];


        Func_scroll(tmp_num);
    }

//  初期値
    void Func_scroll(int M_obj_num)
    {

        for (int i = 0; i < M_obj_num; i++)
        {
            //この３行をどう変えたらいいのか、全く解ってない
            Obj_height.Add(i) = Obj_img_1(i).GetComponent<SpriteRenderer>().bounds.size.y;  //背景１の高さをGET
            Obj_img_1(i).transform.position = new Vector2(0, 0);                            //背景１の初期位置
            Obj_img_2(i).transform.position = new Vector2(0, Obj_height(i));                //背景１の続きの初期位置
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
