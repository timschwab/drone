using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class RadiusUI : MonoBehaviour
{
	public Text text;
	public Slider slider;

	public void Change()
	{
		PlayerPrefs.SetFloat("initialRadius", slider.value*slider.value);
		text.text = "Initial Sphere Radius (" + slider.value*slider.value +")";
	}
}
