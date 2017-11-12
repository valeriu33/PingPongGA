using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreUI : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public int scoreRed;
    public int scoreBlue;
    public GUIStyle style; 

    void OnGUI()
    {
        float x = Screen.width / 2f;
        float y = 30f;
        float width = 300f;
        float heigh = 20f;
        string text = scoreRed + " / " + scoreBlue;

        GUI.Label(new Rect(x - (width / 2f), y, width, heigh), text, style);
    }
}
