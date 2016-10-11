using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour {

	public static int score;        // The player's score.
	
	
	Text text;                      // Reference to the Text component.

	void Awake ()
	{
		// Set up the reference.
		text = GetComponent <Text> ();
		
		// Reset the score.
		score = 0;
	}
	
	
	void Update ()
	{

		text.text = "Score: " + score;
	}
}

