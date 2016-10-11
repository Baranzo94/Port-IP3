using UnityEngine;
using System.Collections;

public class MouseControl : MonoBehaviour {
	
	// Attach to the gameobject
	//This works with the TouchScript package and can be controlled by just Touch Input, doesn't require package's pan method behaviour
	
	float distance = 10;
	
	public void OnMouseDrag()
	{
		Vector3 mousePosition = new Vector3 (Input.mousePosition.x, Input.mousePosition.y, distance);
		Vector3 objPosition = Camera.main.ScreenToWorldPoint (mousePosition);
		
		transform.position = objPosition;
	}
}

