using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
	public GameObject[] hazards;
	public Vector3 spawnValues;
	public int hazardCount;
	public float spawnWait;
	public float startWait;
	public float waveWait;
	
	private bool gameOver;
	private bool restart;
	public static int score;
	public int lives;
	
	public enum TimerType {CountDown};
	public TimerType timerType = TimerType.CountDown;
	
	public float TimeInSeconds = 120f;

	public GameObject heart1;
	public GameObject heart2;
	public GameObject heart3;
	public GameObject gameover;

	public GameObject Resume;
	public GameObject Pause;
	public GameObject Continue;
	
	public Text TimeDisplay;
	
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
		//winGame = false;


  
		score = 0;

		StartCoroutine (SpawnWaves ());
		StartCoroutine (CountDown ());

		heart1.SetActive (true);
		heart2.SetActive (true);
		heart3.SetActive (true);

		gameover.SetActive (false);

		Resolution[] resolutions = Screen.resolutions;
		foreach (Resolution res in resolutions)
		{
			print(res.width + "x" + res.height);
		}
		Screen.SetResolution(resolutions[4].width, resolutions[4].height, true);


	
	}
	
	void Update ()
	{

		// Requires a button to become active for touch versions of game instead of keyboard input
		if (restart)
		{
			if (Input.GetKeyDown (KeyCode.R))
			{
				Application.LoadLevel (Application.loadedLevel);
			}
		}
	}
	
	IEnumerator SpawnWaves ()
	{
		yield return new WaitForSeconds (startWait);
		while (true)
		{
			for (int i = 0; i < hazardCount; i++)
			{
				GameObject hazard = hazards [Random.Range (0, hazards.Length)];
				Vector3 spawnPosition = new Vector3 (Random.Range (-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z);
				Quaternion spawnRotation = Quaternion.Euler(90,90,0);
				Instantiate (hazard, spawnPosition, spawnRotation);
				yield return new WaitForSeconds (spawnWait);
			}
			yield return new WaitForSeconds (waveWait);
			
			if (gameOver)
			{
				restart = true;
				Time.timeScale = 0.0f;
				break;
			}

		}
	}

	IEnumerator CountDown()
	{
		while (TimeInSeconds > 0) 
		{
			yield return new WaitForSeconds(1f);
			TimeInSeconds--;
			UpdateText(TimeInSeconds);
		}

		if (TimeInSeconds == 0) 
		{
			Win ();
		}


	}

	void UpdateText(float amount)
	{
		TimeDisplay.text = "Time Left: " + TimeInSeconds;
	}


	public void Loselife ()
	{
		lives = lives - 1;

		if (lives == 2) 
		{
			heart1.SetActive(false);
		}

		if (lives == 1) 
		{
			heart2.SetActive(false);
		}
		if (lives == 0)
		{
			GameOver();
			heart3.SetActive(false);

		}
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