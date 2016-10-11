using UnityEngine;
using System.Collections;

public class SetResolution : MonoBehaviour {

	// Use this for initialization
	void Start () {
		#if UNITY_EDITOR
		Debug.Log("Unity Editor");
		
		#elif UNITY_IOS
		Debug.Log("Unity iPhone");
		Screen.SetResolution(1024, 768, true);
		#else
		Debug.Log("Any other platform");
		
		#endif
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
