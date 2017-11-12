using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    private Paddle paddle;

    // Use this for initialization
    void Start () {

        paddle = GetComponent<Paddle>();
    }
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.DownArrow))
        {
            paddle.Move(-1);
        }
        else if(Input.GetKey(KeyCode.UpArrow))
        {
            paddle.Move(1);
        }
	}
}
