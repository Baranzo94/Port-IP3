using UnityEngine;
using System.Collections;

public class GreenFruit : MonoBehaviour {
	//Allows calling of score method in gamecontroller, see collision method method
	private GameController gameController;
	public int scoreValue = 10;

	public AudioClip Right;
	public AudioClip Wrong;
	
	void Start () 
	{
		{
			GameObject gameControllerObject = GameObject.FindGameObjectWithTag ("GameController");
			if (gameControllerObject != null)
			{
				gameController = gameControllerObject.GetComponent <GameController>();
			}
			if (gameController == null)
			{
				Debug.Log ("Cannot find 'GameController' script");
			}
		}
	
	}

	void OnTriggerEnter(Collider other) 
	{
		if (other.tag == "Boundary")
		{
			Destroy(other.gameObject);
			Destroy(gameObject);
		}
		
		if (other.tag == "Green") 
		{
			Destroy(other.gameObject);
			Destroy(gameObject);
		}
		
		if (other.tag == "Purple") 
		{
			Destroy(other.gameObject);
			Destroy(gameObject);
		}
		
		if (other.tag == "Red") 
		{
			Destroy(other.gameObject);
			Destroy(gameObject);
		}

		if (other.tag == "Yellow") 
		{
			Destroy(other.gameObject);
			Destroy(gameObject);
		}

		if (other.tag == "CGreen") 
		{
			CollisionGreen();
			GetComponent<AudioSource>().PlayOneShot(Right);
			Debug.Log("Test Green");
		}
		if (other.tag == "CYellow") 
		{
			gameController.Loselife();
			GetComponent<AudioSource>().PlayOneShot(Wrong);
			Destroy(gameObject);

			Debug.Log("Nope not green");
		}
		if (other.tag == "CRed") 
		{
			gameController.Loselife();
			GetComponent<AudioSource>().PlayOneShot(Wrong);
			Destroy(gameObject);

			Debug.Log("Nope not green");
		}
		if (other.tag == "CPurple") 
		{
			gameController.Loselife();
			GetComponent<AudioSource>().PlayOneShot(Wrong);
			Destroy(gameObject);

			Debug.Log("Nope not green");
		}

	}
	
	void CollisionGreen()
	{
		ScoreScript.score += scoreValue;
		Destroy(gameObject);
	}
}
