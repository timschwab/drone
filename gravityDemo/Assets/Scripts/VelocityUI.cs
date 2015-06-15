using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class VelocityUI : MonoBehaviour
{
	public Text text;
	public Slider slider;

	public void Change()
	{
		PlayerPrefs.SetFloat("initialVelocity", slider.value);
		text.text = "Initial Velocity (" + slider.value +")";
	}
}
