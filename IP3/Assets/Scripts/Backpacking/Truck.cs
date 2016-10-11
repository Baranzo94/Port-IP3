using UnityEngine;
using System.Collections;

public class Truck : MonoBehaviour {
	
	public BBgameController gameController;
	public int scoreValue = 30;
	public static bool bagDestroyed;
	public bool bagfull;
	public AudioClip match;
	
	// Use this for initialization
	void Start () {
		
		
		GameObject gameControllerObject = GameObject.FindGameObjectWithTag ("GameController");
		if (gameControllerObject != null)
		{
			gameController = gameControllerObject.GetComponent <BBgameController>();
		}
		if (gameController == null)
		{
			Debug.Log ("Cannot find 'GameController' script");
		}
		
		
	}
	
	// Update is called once per frame
	void Update () {
	}

	
	void OnTriggerEnter(Collider other) 
	{
		if (other.tag == "Basket") 
		{
			CollisionTruck();
			Destroy(other.gameObject);
			GetComponent<AudioSource>().PlayOneShot(match);
			Debug.Log("Test Truck");
			gameController.SpawnBag();
			BagControl.bagfull = false;

		}
	}
	
	void CollisionTruck()
	{
		ScoreScript.score += scoreValue;

		//Destroy(gameObject);
	}
}
