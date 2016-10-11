using UnityEngine;
using System.Collections;

public class CollisionMaster : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
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

		//if (other.tag == "CPurple") {

		//	if (tag == "Purple")
		//	{
		//		Destroy (this.gameObject);
		//		Debug.Log ("YEAH MOTHERFUCKER !");
		//	}
		//}

		if (other.tag == "CPurple")
		
			Debug.Log ("Test One");

		else
		{
			Debug.Log ("Nope");
				return;

		}

		{

			CollisionPurple();
			//if (other.tag == "CPurple")

			//{
			//	Destroy (this.gameObject);
			//	Debug.Log ("It Worked !");
			//}
		}

		if (other.tag == "CRed")
			
			Debug.Log ("Test Red");
		else 
		{
			Debug.Log ("Nope");
			return;
		}

		{
			CollisionRed();
			
		//if (other.tag == "CRed")
		//	
		//	{
		//		Destroy (this.gameObject);
		//		Debug.Log ("It Worked Red!");
		//	}
		}

		if (other.tag == "CGreen")
			
			Debug.Log ("Test Green");
		else 
		{
		Debug.Log ("Nope");
			return;
		}

		{
			CollisionGreen();
			
		//if (other.tag == "CGreen")
			
		//	{
		//		Destroy (this.gameObject);
		//		Debug.Log ("It Worked green !");
		//	}

		}

		if (other.tag == "*")
		{
			return;
		}
		
	} 

	void CollisionRed()
	{
		Destroy(gameObject);
	}

	void CollisionGreen()
	{
		Destroy(gameObject);
	}

	void CollisionPurple()
	{
		Destroy(gameObject);
	}

}
