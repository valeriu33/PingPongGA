using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallGoal : MonoBehaviour {

	// Use this for initialization
	void Start () {
        //StartCoroutine(Example());
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public ePlayer player;
    public ScoreUI score;

    void OnCollisionEnter(Collision col)
    {
        Ball ball = col.gameObject.GetComponent<Ball>();
        if (ball != null)
        {
            //yield return new WaitForSeconds(5);
            ball.transform.position = new Vector3(0f, 1f, 0f);

            if (player == ePlayer.red) score.scoreBlue++;
            else if (player == ePlayer.blue) score.scoreRed++;
        }
    }
}
