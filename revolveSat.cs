using UnityEngine;
using System.Collections;

public class revolveSat : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
//		transform.Rotate(rotationSpeed * Vector3.back * Time.deltaTime);
		transform.Rotate(15 * Time.deltaTime, 10  * Time.deltaTime, 0) ;
	}
}
