using UnityEngine;
using System.Collections;

public class HistoryPage : MonoBehaviour {

	public GameObject Page1;
	public GameObject Page2;
	public GameObject Page3;
	
	public int counter;
	
	public GameObject next;
	public GameObject back;

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
	
		Page1.SetActive (true);
		Page2.SetActive (true);
		Page3.SetActive (true);
		counter = 0;
	}
	
	// Update is called once per frame
	void Update () {

		if (counter == 0) 
			
		{
			Page1.SetActive (true);
			Page2.SetActive (false);
			Page3.SetActive (false);
			next.SetActive (true);
		}
		if (counter == 1) 
			
		{
			back.SetActive (true);
			Page1.SetActive (false);
			Page2.SetActive (true);
			Page3.SetActive (false);
		}

		if (counter == 2) 
			
		{
			Page1.SetActive (false);
			Page2.SetActive (false);
			Page3.SetActive (true);
			next.SetActive (false);
		}
		
		
		if (counter == -1) 
		{
			counter = 0;
			Page1.SetActive (true);
			Page2.SetActive (false);
			Page3.SetActive (false);
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
