using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ParticleGenerator : MonoBehaviour {
	public int defaultCount;
	public float defaultRadius;
	public float defaultVelocity;
	public float defaultGravity;
	
	public ParticleUI partUI;
	public GravityUI gravUI;
	public RadiusUI radUI;
	public VelocityUI velUI;

	public GameObject partPrefab;
	private GameObject[] partList;
	private int partCount;
	private float initialRadius;
	private float initialVelocity;
	private float gravStrength;

	void Start()
	{
		/* Get initialization values */
		partCount = PlayerPrefs.GetInt("partCount", defaultCount);
		gravStrength = PlayerPrefs.GetFloat("gravStrength", defaultGravity);
		initialRadius = PlayerPrefs.GetFloat("initialRadius", defaultRadius);
		initialVelocity = PlayerPrefs.GetFloat("initialVelocity", defaultVelocity);
		
		/* Initialize user interface */
		partUI.text.text = "Particle Count (" + partCount + ")";
		gravUI.text.text = "Gravity Strength (" + gravStrength + ")";
		radUI.text.text = "Initial Sphere Radius (" + initialRadius + ")";
		velUI.text.text = "Initial Velocity (" + initialVelocity + ")";
		
		partUI.slider.value = partCount;
		gravUI.slider.value = gravStrength;
		radUI.slider.value = Mathf.Sqrt(initialRadius);
		velUI.slider.value = initialVelocity;
		
		/* Create particles */
		partList = new GameObject[partCount];
		for (int i = 0 ; i < partCount ; i++)
		{
			partList[i] = (GameObject) Instantiate(partPrefab);
			partList[i].GetComponent<Particle>().setVars(
			initialRadius,
			initialVelocity,
			gravStrength);
		}
	}
	
	public GameObject[] getPartList()
	{
		return partList;
	}

	public GameObject getPart(int i)
	{
		return partList[i];
	}
}
