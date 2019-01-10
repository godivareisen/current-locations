using UnityEngine;
using System.Collections;

public class revolveSat_04 : MonoBehaviour {

	public float degrees = 10;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
//		transform.Rotate(rotationSpeed * Vector3.back * Time.deltaTime);
		transform.Rotate(0, 0, degrees  * Time.deltaTime) ;
	}
}
