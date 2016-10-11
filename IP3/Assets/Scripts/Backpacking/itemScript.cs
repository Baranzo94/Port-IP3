using UnityEngine;
using System.Collections;

public class itemScript : MonoBehaviour {
	public float speed;
	public float lifetime;
	private BBgameController BBgameController;

	// Use this for initialization
	void Start () {

		GetComponent<Rigidbody>().velocity = transform.right * speed;
		Destroy (gameObject, lifetime);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other) 
	{
		if (other.tag == "ItemWait")
		{
			speed = 0.0f;
			GetComponent<Rigidbody>().velocity = Vector3.zero;
			BBgameController.itemsReady = false;
			Debug.Log ("Items Stop");
		}

		if (other.tag == "Item") 
		{
			GetComponent<Rigidbody>().velocity = Vector3.zero;
		}
	}
}
