using UnityEngine;
using System.Collections;

public class revolveSat_02 : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		//		transform.Rotate(rotationSpeed * Vector3.back * Time.deltaTime);
		transform.Rotate(35 * Time.deltaTime, 0, 20  * Time.deltaTime) ;
	}
}
