using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class T_Scroll : MonoBehaviour
{
    /*======================================================================================
     *   T_Scrollは、背景スクロールするプログラムである。
     *   仕様シーンは、sceen、titleである。
     *======================================================================================*/




    /*＜質問＞ここで定義、実体化したら、配列数が３になる。*/
    /*
        public float[] ScrollSpeed = new float[3];
        public float[] ObjHeight = new float[3];
        public GameObject[] ObjImage1 = new GameObject[3];
        public GameObject[] ObjImage2 = new GameObject[3];
        public int[] ScrollDirection = new int[3];
        public int[] ObjDepth = new int[3];
    */

    public float[] ScrollSpeed = new float[3];
    public float[] ObjHeight = new float[3];
    public GameObject[] ObjImage1 = new GameObject[3];
    public GameObject[] ObjImage2 = new GameObject[3];
    public int[] ScrollDirection = new int[3];
    public int[] ObjDepth = new int[3];
    /* 井田天へ
     * 質問があります。
     * コメントアウトした所で質問です。
        public float[] ScrollSpeed;
        public float[] ObjHeight;
        public GameObject[] ObjImage1;
        public GameObject[] ObjImage2;
        public int[] ScrollDirection;
        public int[] ObjDepth;
    */
    public int ObjNumber = new int();
    //    public int j = new int();
    // Use this for initialization
    void Start()
    {
        /*
         *      ＜質問＞
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              *      ここで実体化したら、配列数が３にならない。
         * 
                ScrollSpeed = new float[3];
                ObjHeight = new float[3];
                ObjImage1 = new GameObject[3];
                ObjImage2 = new GameObject[3];
                ScrollDirection = new int[3];
                ObjDepth = new int[3];
        */
        ObjNumber = 3;

        FuncSet(ObjNumber);

    }



    // Update is called once per frame
    void Update()
    {
        FuncScroll(ObjNumber);
    }

    //  初期値設定
    public void FuncSet(int objectnumber)
    {

        for (int i = 0; i < objectnumber; i++)
        {
            ObjHeight[i] = ObjImage1[i].GetComponent<SpriteRenderer>().bounds.size.y;
            //        ObjDepth[i] = ObjImage1[i].GetComponent<SpriteRenderer>().sortingOrder;
            ObjDepth[i] = ObjImage1[i].GetComponent<Renderer>().sortingOrder;
            ObjDepth[i] = -1 * i;
            //https://qiita.com/yuzupon/items/075da77f39d5d2c5b366
            ObjImage1[i].transform.position = new Vector2(0, 0);
            ObjImage2[i].transform.position = new Vector2(0, ObjHeight[i]);
        }
    }

     public   void FuncScroll(int objectnumber)
        {
            for (int i = 0; i < objectnumber; i++)
            {
                ObjImage1[i].transform.Translate(0, ScrollDirection[i] * ScrollSpeed[i], 0);
                ObjImage2[i].transform.Translate(0, ScrollDirection[i] * ScrollSpeed[i], 0);

                if (ObjImage1[i].transform.position.y <= ScrollDirection[i] * ObjHeight[i])
                {
                    ObjImage1[i].transform.position = new Vector2(0, 0);
                }
                if (ObjImage2[i].transform.position.y <= 0)
                {
                    ObjImage2[i].transform.position = new Vector2(0.0f,ObjHeight[i]);
                }
            }


        }
        //               v.transform.position = new Vector2(0.0f, -0.75f);
    }                                                         