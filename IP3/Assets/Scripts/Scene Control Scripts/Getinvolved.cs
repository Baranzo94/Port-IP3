using UnityEngine;
using System.Collections;

public class Getinvolved : MonoBehaviour {
	public GameObject Page1;
	public GameObject Page2;
	public GameObject Page3;
	public GameObject Page4;
	public GameObject Page5;
	
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
		Page2.SetActive (false);
		Page3.SetActive (false);
		Page4.SetActive (false);
		Page5.SetActive (false);
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
			Page1.SetActive (true);
			Page2.SetActive (false);
			Page3.SetActive (false);
			Page4.SetActive (false);
			Page5.SetActive (false);
		}
		if (counter == 1) 
			
		{
			next.SetActive (true);
			back.SetActive (true);
			Page1.SetActive (false);
			Page2.SetActive (true);
			Page3.SetActive (false);
			Page4.SetActive (false);
			Page5.SetActive (false);
			
		}
		if (counter == 2) 
			
		{
			next.SetActive (true);
			back.SetActive (true);
			Page1.SetActive (false);
			Page2.SetActive (false);
			Page3.SetActive (true);
			Page4.SetActive (false);
			Page5.SetActive (false);
			
		}
		if (counter == 3) 
			
		{
			next.SetActive (true);
			back.SetActive (true);
			Page1.SetActive (false);
			Page2.SetActive (false);
			Page3.SetActive (false);
			Page4.SetActive (true);
			Page5.SetActive (false);
			
		}

		if (counter == 4) 
		{
			next.SetActive (false);
			back.SetActive (true);
			Page1.SetActive (false);
			Page2.SetActive (false);
			Page3.SetActive (false);
			Page4.SetActive (false);
			Page5.SetActive (true);
		}
		
		if (counter == -1) 
		{
			next.SetActive (true);
			back.SetActive (false);
			counter = 0;
			Page1.SetActive (true);
			Page2.SetActive (false);
			Page3.SetActive (false);
			Page4.SetActive (false);
			Page5.SetActive (false);
		}
		
		
	}
}
