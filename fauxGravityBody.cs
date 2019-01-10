using UnityEngine;
using System.Collections;

public class fauxGravityBody : MonoBehaviour {

	public fauxGravityAttractor attractor;
	private Transform myTransform;

	void Start () {
		GetComponent<Rigidbody> ().constraints = RigidbodyConstraints.FreezeRotation;
		GetComponent<Rigidbody> ().useGravity = false;
		myTransform = transform;
		
	}

	void Update () {
		attractor.Attract (myTransform);
	}
}
