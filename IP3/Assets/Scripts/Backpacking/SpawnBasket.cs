using UnityEngine;
using System.Collections;

public class SpawnBasket : MonoBehaviour
{
	public Transform spawnPoint;
	public GameObject basket;
	public float spawnStart;
	public float timer;
	public int spawnTotal;

	void Start ()
	{
		StartCoroutine (SpawnGameObject());	
	}
		
	void update()
	{

	}
		
	IEnumerator SpawnGameObject()
	{
		yield return new WaitForSeconds (spawnStart);
		while (true)
		{
			for (int x = 0; x < spawnTotal; x++)
			{
				Instantiate (basket, spawnPoint.position, spawnPoint.rotation);
				yield return new WaitForSeconds (timer);
			}
		}
	}

}