using UnityEngine;
using System.Collections;

public class ChangeScene : MonoBehaviour {
	//public GameObject MainMenuMusic;

	public void Start(){

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
		//MainMenuMusic = GameObject.Find ("MainMenuMusic");
		//DontDestroyOnLoad (MainMenuMusic);
	}
	/*public void changeScene( string sceneToChangeTo ){
		if (sceneToChangeTo == "GameTest") {
						//MainMenuMusic.audio.Stop ();
				}
		Application.LoadLevel (sceneToChangeTo);

	}*/

	public void changeScene( int sceneToChangeTo )
	{
		Application.LoadLevel (sceneToChangeTo);
	}


}