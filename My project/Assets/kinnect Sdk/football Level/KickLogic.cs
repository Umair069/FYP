using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;
using UnityEngine.UI;
using UnityEngine.SocialPlatforms.Impl;

public class KickLogic : MonoBehaviour
{
    public GameObject Foot_Left;
    public GameObject Ball;
    public GameObject Foot_Right;
    public bool turn;
    public bool Kick;
    public Text kickText;
    public Text score;
    private int gameScore = 0;

    // Start is called before the first frame update
    void Start()
    {
        turn = true;
    }

    // Update is called once per frame
    void Update()
    {
        
        Vector3 leftFootDist = Foot_Left.transform.position;
        Vector3 BallDist = Ball.transform.position;

        Vector3 rightFootDist = Foot_Right.transform.position;
        if(turn == true)
        {
            kickText.text = "Left Kick";
            if (Vector3.Distance(leftFootDist, BallDist) <= 0.4f)
            {
                Kick = true;
                turn = false;
                ScoreIncrement();
            }
        }
        else if( turn == false)
        {
            kickText.text = "Right Kick";
            if (Vector3.Distance(rightFootDist, BallDist) <= 0.4f)
            {
                Kick = true;
                turn = true;
                ScoreIncrement();
            }
        }
        

        
        
    }
    void ScoreIncrement()
    {
        gameScore = gameScore + 1;
        score.text = gameScore.ToString();
    }
}
