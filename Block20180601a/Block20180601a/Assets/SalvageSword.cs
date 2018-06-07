using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SalvageSword : MonoBehaviour {

    public bool MouseButonLeft = new bool();
//    public GameObject SalvegeSwordObject = new GameObject();
    public GameObject SS_obj = new GameObject();
    public Vector3 SalvegeSwordObjectPosition = new Vector3();
    public bool SalvegeSwordObjectFlag = new bool();
    public int AnimationCounter = new int();
    public bool AnimationCounterFlag = new bool();
    public float rote_x = new float();
    public float rote_y = new float();
    public float add_rote_x = new float();
    public float add_rote_y = new float();
    public float rote_z = new float();
    public float AnimationBichoX = new float();
    public float AnimationBichoY = new float();

    // Use this for initialization
    void Start() {

//        public GameObject SS_obj = new GameObject();
        MouseButonLeft = false;
        SalvegeSwordObjectFlag = false;
        AnimationCounter = 0;
        rote_z = 0;
        AnimationBichoX = 1.7f;
        AnimationBichoY = -0.5f;


    }

    // Update is called once per frame
    void Update () {
		
        MouseButonLeft = Input.GetMouseButton(0);

        if ((MouseButonLeft == false) && (SalvegeSwordObjectFlag == true) && (AnimationCounterFlag == false))
        {
            if (SalvegeSwordObjectFlag == true)
            {
                Destroy(SS_obj);
                SalvegeSwordObjectFlag = false;
                AnimationCounterFlag = false;
            }

        }

                if ((MouseButonLeft == true) && (SalvegeSwordObjectFlag == false) && (AnimationCounterFlag == false))
//        if ((MouseButonLeft == true) && (SalvegeSwordObjectFlag == 0))
        {
            SalvegeSwordObjectPosition.x = GameObject.Find("ziki").GetComponent<Paddle_move>().transform.position.x + AnimationBichoX;
            SalvegeSwordObjectPosition.y = GameObject.Find("ziki").GetComponent<Paddle_move>().transform.position.y + AnimationBichoY;
            SS_obj = Instantiate(Resources.Load("SalvegeSword_pref"), new Vector3(SalvegeSwordObjectPosition.x, SalvegeSwordObjectPosition.y, 0.0f), Quaternion.identity) as GameObject;
            SalvegeSwordObjectFlag = true;
            AnimationCounterFlag = true;
            AnimationCounter = 0;
            //add_rote_x = 0;
            //add_rote_y = 0;
            rote_z = 0;
        }
        //            AnimationCounter = 0;
        //            Debug.Log("MouseButonLeft : " + MouseButonLeft);
        if (AnimationCounterFlag == true)
        {
                if (AnimationCounter >=45)
                {
                    AnimationCounter = 45;
                    rote_z = rote_z;
                    SS_obj.transform.Rotate(new Vector3(0, 0, rote_z));
                    AnimationCounterFlag = false;
                }
                else if (AnimationCounter <= 44)
                {
                //                rote_z = rote_z + 0.05f;
                rote_x = rote_x + add_rote_x;
                rote_y = rote_y + add_rote_y;
                rote_z = rote_z + 0.1f;
                //                //Ziki.transform.position = new Vector3(MaXLeft, ZikiPositionY, 0.0f);
                //                SS_obj.transform.position = new Vector3(
//                SS_obj.transform.Rotate(new Vector3(0, 0, rote_z));
                SS_obj.transform.Rotate(new Vector3(rote_x, rote_y, rote_z));
                AnimationCounter = AnimationCounter + 1;
                }
            else
                {
                    rote_z = rote_z;
                    AnimationCounter = AnimationCounter;
                }
                //            SalvegeSwordObjectPosition.x = GameObject.Find("ziki").GetComponent<Paddle_move>().transform.position.x;
                //            SalvegeSwordObjectPosition.y = GameObject.Find("ziki").GetComponent<Paddle_move>().transform.position.y;
                //SS_obj.transform.Rotate(new Vector3(0, 0, rote_z));
                //           rote_z = rote_z + 30;
                //Debug.Log("AnimationCounterFlag : " + AnimationCounterFlag);
                Debug.Log("AnimationCounter : " + AnimationCounter);
                Debug.Log("rote_z : " + rote_z);
        }

    }
}
