using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triger : MonoBehaviour
{

    public GameObject gameObject;
    public GameObject B_obj;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D c)
    {
        string tag = c.gameObject.tag;

        if (tag == "ball")
        {
            GetComponent<Ball_move>();

            Destroy(B_obj);
        }



        /*======================================================================================
         *   OLD   OnTriggerEnterを使用していた。
         *
          ====================================================================================*/
        /*    void OnTriggerEnter(Collider c)
            {
                if (c.gameObject.tag == "ball")
                {
                    GetComponent<Ball_move>();

                    Destroy(B_obj);
                }


                return;
            }
        */
    }
}
