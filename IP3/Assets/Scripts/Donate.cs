using UnityEngine;
using System.Collections;

public class Donate : MonoBehaviour {

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
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
