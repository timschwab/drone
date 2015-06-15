using UnityEngine;
using System.Collections;

public class RestartButton : MonoBehaviour {

	public void Click()
	{
		PlayerPrefs.Save();
		Application.LoadLevel(Application.loadedLevel);
	}
}
