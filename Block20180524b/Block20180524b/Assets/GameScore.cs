using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameScore : MonoBehaviour {
    /*=============================================================================
     * GameScoreは、ブロックを破壊した時にSCOREを加算していくプログラムである。
     * score 変数にBall_moveクラスを継承してBall_moveクラスの変数poiintを
     * GameScoreクラスの変数scoreに代入っしている。
      =============================================================================*/
    public Text ScoreLabel;

    public int score;

    // Use this for initialization
    void Start () {
	}
	
	// Update is called once per frame
	void Update ()
    {
        score = GetComponent<Ball_move>().point;
        ScoreLabel.text = "SCORE : " + score;
    }




}
