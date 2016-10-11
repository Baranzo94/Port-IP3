using UnityEngine;
using System.Collections;

public class Tutorial2 : MonoBehaviour {

	public GameObject Tut1;
	public GameObject Tut2;
	public GameObject Tut3;
	public GameObject Tut4;

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
		Tut3.SetActive (false);
		Tut4.SetActive (false);
		counter = 0;
	}
	public void NextPress()
	{
		counter = counter + 1;
	}
	public void BackPress()
	{
		counter = counter - 1;
	}
	// Update is called once per frame
	void Update () {

		if (counter == 0) 

		{
			next.SetActive (true);
			back.SetActive (false);
			Tut1.SetActive (true);
			Tut2.SetActive (false);
			Tut3.SetActive (false);
			Tut4.SetActive (false);

		}
		if (counter == 1) 
			
		{
			next.SetActive (true);
			back.SetActive (true);
			Tut1.SetActive (false);
			Tut2.SetActive (true);
			Tut3.SetActive (false);
			Tut4.SetActive (false);
			
		}
		if (counter == 2) 
			
		{
			next.SetActive (true);
			back.SetActive (true);
			Tut1.SetActive (false);
			Tut2.SetActive (false);
			Tut3.SetActive (true);
			Tut4.SetActive (false);
			
		}
		if (counter == 3) 
			
		{
			next.SetActive (false);
			back.SetActive (true);
			Tut1.SetActive (false);
			Tut2.SetActive (false);
			Tut3.SetActive (false);
			Tut4.SetActive (true);
			
		}

		if (counter == -1) 
		{
			counter = 0;
			next.SetActive (true);
			back.SetActive (false);
			Tut1.SetActive (true);
			Tut2.SetActive (false);
			Tut3.SetActive (false);
			Tut4.SetActive (false);
		}

	
	}
}
