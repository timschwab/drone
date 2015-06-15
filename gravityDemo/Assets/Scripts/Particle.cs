using UnityEngine;
using System.Collections;

public class Particle : MonoBehaviour {
	private float initialRadius;
	private float initialVelocity;
	private float gravStrength;

	private ParticleGenerator generator;

	public void setVars(float radius, float velocity, float gravity)
	{
		initialRadius = radius;
		initialVelocity = velocity;
		gravStrength = gravity;
	}

	void Start()
	{
		generator = GameObject.FindWithTag("GameController").GetComponent<ParticleGenerator>();
		
		transform.position = Random.insideUnitSphere * initialRadius;
		rigidbody.velocity = Random.insideUnitSphere * initialVelocity;
	}

	Vector3 CalcForce(GameObject obj)
	{		
		Vector3 vector;
		Vector3 direction;
		float distance;
		float magnitude;
		
		vector = obj.transform.position - transform.position;
		direction = vector.normalized;
		distance = vector.magnitude + 1f;
		magnitude = 1/(distance*distance);
		
		return (direction*magnitude);
	}

	void Update()
	{
		foreach (GameObject particle in generator.getPartList())
			rigidbody.AddForce(CalcForce(particle) * gravStrength);
	}
}
