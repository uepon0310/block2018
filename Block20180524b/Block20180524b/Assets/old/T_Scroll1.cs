using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

    public float move_scroll1;//背景スクロールのスピード

    public GameObject fab_obj1;//背景スクロールの画像
    public GameObject fab_obj2;

    [SerializeField]
    private Vector2 pos1;//背景スクロールの画像のポジション　いらないかも？


    [SerializeField]
    public float posheight1;//背景スクロールの画像の高さ

    // Use this for initialization
    void Start()
    {
        //背景１のスクロール
        posheight1 = fab_obj1.GetComponent<SpriteRenderer>().bounds.size.y;//背景１の高さをGET
        pos1 = fab_obj2.transform.position;
        fab_obj1.transform.position = new Vector2(0, 0);//背景１の初期位置
        fab_obj2.transform.position = new Vector2(0, posheight1);//背景１の続きの初期位置

    }

    // Update is called once per frame
    void Update()
    {
        /*=====背景１の移動量設定====================================================================================================*/
        fab_obj1.transform.Translate(0, move_scroll1, 0);//背景１の移動
        fab_obj2.transform.Translate(0, move_scroll1, 0);//背景１の続きの移動

        if (fab_obj1.transform.position.y <= -1 * posheight1)//背景１の高さ分移動したら背景１は、元の位置に
        {
            fab_obj1.transform.position = new Vector2(0, 0);
        }
        if (fab_obj2.transform.position.y <= 0)//背景１の続きの高さ分移動したら背景１の続きは、元の位置に
        {
            fab_obj2.transform.position = new Vector2(0, posheight1);
        }




    }

}
