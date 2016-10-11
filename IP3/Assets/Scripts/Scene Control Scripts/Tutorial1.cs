using UnityEngine;
using System.Collections;

public class Tutorial1 : MonoBehaviour {

	public GameObject Tut1;
	public GameObject Tut2;
	
	public int counter;
	
	public GameObject next;
	public GameObject back;
	public GameObject Play;
	// Use this for initialization

	void Start () {
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

		next.SetActive (true);
		back.SetActive (false);

		Tut1.SetActive (true);
		Tut2.SetActive (false);
		counter = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
		if (counter == 0) 
			
		{
			back.SetActive (false);
			next.SetActive (true);
			Tut1.SetActive (true);
			Tut2.SetActive (false);	
		}
		if (counter == 1) 
			
		{
			Tut1.SetActive (false);
			Tut2.SetActive (true);
			next.SetActive (false);
			back.SetActive (true);
		}

		
		if (counter == -1) 
		{
			counter = 0;
			Tut1.SetActive (true);
			Tut2.SetActive (false);
		}
		
		
	}

	public void NextPress()
	{
		counter = counter + 1;
	}
	public void BackPress()
	{
		counter = counter - 1;
	}


}
