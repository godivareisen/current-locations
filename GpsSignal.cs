using UnityEngine;
using System.Collections;

public class GpsSignal : MonoBehaviour {

	public static int count = 0;

	// Use this for initialization
	void Start () {

	}

	//	 Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter(Collider col) {
		if (col.gameObject.tag == "person") {
			count--;
			print ("hit");
			print (count);
		}

	}

	void OnTriggerExit(Collider col) {
		if (col.gameObject.tag == "person") {
			count++;
			print ("exit");
			print (count);
		}
	}
				
}
