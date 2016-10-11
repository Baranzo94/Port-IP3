using UnityEngine;
using System.Collections;
// Responsible for Destroying the gameobject after the specified time entered in the GameController Gameobject
public class DestroyByTime : MonoBehaviour
{
	public float lifetime;
	
	void Start ()
	{
		Destroy (gameObject, lifetime);
	}
}
