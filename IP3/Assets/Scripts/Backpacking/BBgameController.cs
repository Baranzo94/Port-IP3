using UnityEngine;
using UnityEngine.UI;
using System.Collections;
//using System.Collections.Generic;

public class BBgameController : MonoBehaviour 
{
	public GameObject[] items;
	public Vector3 spawnValues;
	public int itemCount;
	public float spawnWait;
	public float startWait;
	public float waveWait;
	
	private bool gameOver;
	private bool restart;
	public int score;

	public Truck TruckScript;
	Text text;

	public static bool itemsReady;

	public GameObject gameover;

	public GameObject Resume;
	public GameObject Pause;
	public GameObject Continue;
	
	public GameObject stopPoint;

	public GameObject bag;
	public Vector3 bagValues;

	//public static bool bagDestroyed = false;

	
	public enum TimerType {CountDown};
	public TimerType timerType = TimerType.CountDown;
	
	public float TimeInSeconds = 60f;

	public Text TimeDisplay;
	public int bagCheck;

	public GameObject bagStatusFull;
	public GameObject bagStatusNot;

	public bool bagfull;

	void Start ()
	{
		
		#if UNITY_EDITOR
		Debug.Log("Unity Editor");
		
		#elif UNITY_IOS
		Debug.Log("Unity iPad Retina");
		Screen.SetResolution(1024, 768, true);
		
		#elif UNITY_ANDROID
		Debug.Log("Unity Android");
		Screen.SetResolution(1024, 600, true);
		
		#else
		Debug.Log("Any other platform");
		
		#endif
		
		gameOver = false;
		restart = false;
		//bagDestroyed = false;

		itemsReady = false;

		score = 0;

		StartCoroutine (SpawnWaves ());
		
		StartCoroutine (CountDown());

		//StartCoroutine (BagCheck());

		//bag = GameObject.Find("Basket");
		SpawnBag ();
		
		gameover.SetActive (false);

		bagStatusFull.SetActive (false);
		bagStatusNot.SetActive (true);
		
		Resolution[] resolutions = Screen.resolutions;
		foreach (Resolution res in resolutions) {
			print(res.width + "x" + res.height);
		}
		Screen.SetResolution(resolutions[4].width, resolutions[4].height, true);
		
	}


	void Update ()
	{
		if (BagControl.bagfull == true)
		{
			bagStatusFull.SetActive (true);
			bagStatusNot.SetActive (false);
		}

		if (BagControl.bagfull == false)
		{
			bagStatusFull.SetActive (false);
			bagStatusNot.SetActive (true);
		}


		// Requires a button to become active for touch versions of game instead of keyboard input
		if (restart)
		{
			if (Input.GetKeyDown (KeyCode.R))
			{
				Application.LoadLevel (Application.loadedLevel);
			}
		}
	}
	//public Rigidbody basket;

	public void SpawnBag()
	{
			//StartCoroutine (BagCheck());
		//bagDestroyed = false;

		Instantiate (bag, new Vector3 (bagValues.x, bagValues.y, bagValues.z), Quaternion.Euler (90, 90, 0));
		//Rigidbody basketClone = (Rigidbody) Instantiate (basket, new Vector3 (bagValues.x, bagValues.y, bagValues.z), Quaternion.Euler (90, 90, 0));
	}

	IEnumerator BagCheck()
	{
		yield return new WaitForSeconds (1);

		{
			Vector3 bagPosition = new Vector3 (bagValues.x, bagValues.y,bagValues.z);
			Quaternion bagRotation = Quaternion.Euler (90, 90, 0);
			Instantiate (bag ,bagPosition, bagRotation);
		}
	}
	
	IEnumerator SpawnWaves ()
	{
			yield return new WaitForSeconds (startWait);
			while (true) {
				for (int i = 0; i < itemCount; i++) {
					GameObject item = items [Random.Range (0, items.Length)];
					Vector3 spawnPosition = new Vector3 (spawnValues.x, spawnValues.y, spawnValues.z);
					Quaternion spawnRotation = Quaternion.Euler (90, 90, 0);
					Instantiate (item, spawnPosition, spawnRotation);
					yield return new WaitForSeconds (spawnWait);
			
				}
				yield return new WaitForSeconds (waveWait);
			
				if (gameOver) {
					//Triggers Restart
					restart = true;
					break;
				}
			}

	}

	IEnumerator CountDown()
	{
		while (TimeInSeconds > 0) {
			yield return new WaitForSeconds (1f);
			TimeInSeconds--;
			UpdateText (TimeInSeconds);
		}
		
		if (TimeInSeconds == 0) {
			Win ();
		}
	
	}
	
	void UpdateText(float amount)
	{
		TimeDisplay.text = "Time Left: " + TimeInSeconds;
	}
	
	
	public void Win()
		{
			gameOver = true;
			gameover.SetActive (true);
			Debug.Log ("YOU WIN !");
			Time.timeScale = 0.0f;
			Resume.SetActive (false);
			Pause.SetActive (false);
		Continue.SetActive (true);
			
			
		}
		
		public void GameOver ()
		{
			gameOver = true;
			gameover.SetActive (true);
			Debug.Log ("GAME OVER !");
			Time.timeScale = 0.0f;
			Resume.SetActive (false);
			Pause.SetActive (false);
		}
}