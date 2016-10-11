using UnityEngine;
using System.Collections;

public class BasketCollision : MonoBehaviour {
	
	private GameController gameController;
	
	// Use this for initialization
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
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnTriggerEnter(Collider other) 
	{
		if (other.tag == "Boundary")
		{
			Destroy(other.gameObject);
			Destroy(gameObject);
		}

		if (other.tag == "Basket") 
		{
			Destroy(other.gameObject);
			Destroy(gameObject);
		}
	}
}
