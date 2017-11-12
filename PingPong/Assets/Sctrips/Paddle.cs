using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ePlayer
{
    red,
    blue
}

public class Paddle : MonoBehaviour {

    public float speed = 15f;
    public ePlayer player;
    public bool bot;

	// Use this for initialization
	void Start ()
    {

	}

    public void Move(float direction)
    {
        transform.position += new Vector3(0f, 0f, direction * speed * Time.deltaTime);
    }
}
