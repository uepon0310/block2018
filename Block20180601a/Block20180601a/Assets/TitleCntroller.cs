using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleCntroller : MonoBehaviour {

    /*======================================================================================
     *   TitleCntrollerは、titleシーンから、sceenシーンに遷移するプログラムである。
     *   仕様シーンは、titleである。
     *======================================================================================*/

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void GameStart()
    {
        SceneManager.LoadScene("sceen");

        
    }
}
