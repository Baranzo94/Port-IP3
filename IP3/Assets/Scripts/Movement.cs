using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour
{
	public float speed;
	
	void Start ()
	{
		GetComponent<Rigidbody>().velocity = transform.forward * speed;
	}

	/*void Update () 
	{
		Touch myTouch = Input.GetTouch(0);
		
		Touch[] myTouches = Input.touches;
		for(int i = 0; i < Input.touchCount; i++)
		{
			//Do something with the touches
			//speed=0;
			Debug.Log("Touch Accepted");

		}
	}*/
}