using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bot : MonoBehaviour {

    Ball ball;
    Paddle paddle;

    public bool god = false;

	// Use this for initialization
	void Start () {
        ball = GameObject.Find("Ball").GetComponent<Ball>();
        paddle = GetComponent<Paddle>();
    }
	
	// Update is called once per frame
	void Update () {
        if(god)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, ball.transform.position.z);
        }
        else
        {
            if(ball.transform.position.z > transform.position.z)
            {
                paddle.Move(1);
            }
            else if(ball.transform.position.z < transform.position.z)
            {
                paddle.Move(-1);
            }
        }
        
        //ball.transform.position.z

	}
}
