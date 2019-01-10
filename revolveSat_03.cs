using UnityEngine;
using System.Collections;

public class revolveSat_03 : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		//		transform.Rotate(rotationSpeed * Vector3.back * Time.deltaTime);
		transform.Rotate(2  * Time.deltaTime, 0, 20  * Time.deltaTime) ;
	}
}
