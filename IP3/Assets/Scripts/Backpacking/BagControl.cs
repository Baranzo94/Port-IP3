using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BagControl : MonoBehaviour {

	// Use this for initialization
	float distance = 10;
	public static bool bagfull;
	public int noOfItems;

	public AudioClip match;


	void Start()
	{
		bagfull = false;


	}

	void Update()
	{
		bagCheck ();
	}

	void OnTriggerEnter(Collider other) 
	{
		if (other.tag == "Item") 
		{
			noOfItems = noOfItems + 1;
			GetComponent<AudioSource>().PlayOneShot(match);
			Destroy(other.gameObject);
			bagfull = false;
		}
	}

	public void bagCheck()
	{
		/*if (noOfItems == 4) 
		{
			bagfull = true;
			//Debug.Log ("Bag is now full");
		}*/

		if (noOfItems >= 4) 
		{
			bagfull = true;
		}
	}

	public void OnMouseDrag()
	{
	  if (bagfull == true)
		{
			Vector3 mousePosition = new Vector3 (Input.mousePosition.x, Input.mousePosition.y, distance);
			Vector3 objPosition = Camera.main.ScreenToWorldPoint (mousePosition);
		
			transform.position = objPosition;

		}
	}
}

