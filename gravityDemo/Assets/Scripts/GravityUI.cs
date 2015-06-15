using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GravityUI : MonoBehaviour
{
	public Text text;
	public Slider slider;

	public void Change()
	{
		PlayerPrefs.SetFloat("gravStrength", slider.value);
		text.text = "Gravity Strength (" + slider.value +")";
	}
}
