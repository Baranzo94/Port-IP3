using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class pauseScene : MonoBehaviour {

	public GameObject Resume;
	public GameObject Pause;
	public GameObject Exit;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	
	}

	 public void pauseGame (bool pause)
	{


		if (pause = true) 
		{
			Time.timeScale = 0.0f;
			Resume.SetActive (true);
			Pause.SetActive (false);
			Exit.SetActive (true);
		}

		 if (pause = false)
		{
			Resume.SetActive (false);
			Pause.SetActive (true);
			Exit.SetActive (false);
		}


	}

	public void resumeGame (bool pause)
	{

		Time.timeScale = 1.0f;
		Pause.SetActive (true);
		Resume.SetActive (false);
		Exit.SetActive (false);

	}
}
