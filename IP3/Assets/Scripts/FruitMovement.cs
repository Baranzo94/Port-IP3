using UnityEngine;
using System.Collections;
//Responsible for the speed and movement of applied gameobjects, speed variable is altered on prefab
public class FruitMovement : MonoBehaviour {

public float speed;

		

	void Start () 
	{
			
		GetComponent<Rigidbody>().velocity = transform.right * speed;

			
	}
	
}
