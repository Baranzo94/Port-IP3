using UnityEngine;
using System.Collections;

public class DestroyByContact : MonoBehaviour
{
	void OnTriggerEnter(Collider other) 
	{
		if (other.tag == "Boundary")
		{
			return;
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

		if (other.tag == "red") 
		{
			Destroy(other.gameObject);
			Destroy(gameObject);
		}

	}
}
