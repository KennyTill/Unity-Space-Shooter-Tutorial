using UnityEngine;
using System.Collections;

public class RandomRotator : MonoBehaviour {

	public float Tumble;
	private Rigidbody rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		rb.angularVelocity = Random.insideUnitSphere * Tumble;
	}
}
