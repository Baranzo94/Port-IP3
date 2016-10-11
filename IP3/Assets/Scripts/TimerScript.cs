using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour {
	
	public static float TimeInSeconds;
	
	Text text;                
	
	void Awake ()
	{
		// Set up the reference.
		text = GetComponent <Text> ();
		// Reset the score.
		TimeInSeconds = 0.0f;
	
	}
	
	
	void Update ()
	{
		Debug.Log (string.Format ("TimeLeft {0}", TimeInSeconds));
		text.text = "Time Left: " + TimeInSeconds/*.ToString()*/;
	}
}

