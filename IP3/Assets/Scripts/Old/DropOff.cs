using UnityEngine;
using System.Collections;

public class DropOff : MonoBehaviour
	
{
	public GameObject other;	

	void OnCollisionEnter (Collision col)
	{
		if(col.gameObject.tag == "Purple")
		{
			//Destroy(col.gameObject);
			Destroy(other);
		}
	}
}