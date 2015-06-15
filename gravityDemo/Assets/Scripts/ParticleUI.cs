using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ParticleUI : MonoBehaviour
{
	public Text text;
	public Slider slider;

	public void Change()
	{
		PlayerPrefs.SetInt("partCount", Mathf.RoundToInt(slider.value));
		text.text = "Particle Count (" + slider.value +")";
	}
}
