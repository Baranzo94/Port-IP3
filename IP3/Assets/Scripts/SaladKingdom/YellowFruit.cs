using UnityEngine;
using System.Collections;

public class YellowFruit : MonoBehaviour {

	private GameController gameController;
	public int scoreValue = 10;

	public AudioClip Right;
	public AudioClip Wrong;


	void Start () {

		
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

		if (other.tag == "CYellow")
			
			Debug.Log ("Test Yellow");

		if (other.tag == "CYellow") 
		{
			CollisionYellow();
			GetComponent<AudioSource>().PlayOneShot(Right);
			Debug.Log("Test Yellow");
		}
		if (other.tag == "CGreen") 
		{
			gameController.Loselife();
			Destroy(gameObject);
			GetComponent<AudioSource>().PlayOneShot(Wrong);
			Debug.Log("Nope not Yellow");
		}
		if (other.tag == "CRed") 
		{
			gameController.Loselife();
			Destroy(gameObject);
			GetComponent<AudioSource>().PlayOneShot(Wrong);
			Debug.Log("Nope not Yellow");
		}
		if (other.tag == "CPurple") 
		{
			gameController.Loselife();
			Destroy(gameObject);
			GetComponent<AudioSource>().PlayOneShot(Wrong);
			Debug.Log("Nope not Yellow");
		}
	}

	void CollisionYellow()
	{
		ScoreScript.score += scoreValue;
		Destroy(gameObject);
	}
}
