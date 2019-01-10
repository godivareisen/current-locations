using UnityEngine;
using System.Collections;

public class test : MonoBehaviour {

//	GpsSignal gpsSignal = null;

	// Use this for initialization
	void Start () {
//		GameObject collider = GameObject.FindWithTag ("collider");
//		gpsSignal = collider.GetComponent<GpsSignal> ();
		GetComponent<SkinnedMeshRenderer> ().enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
//		if (gpsSignal.count == 0) {
//			GetComponent<SkinnedMeshRenderer> ().enabled = true;
//		} else if (gpsSignal.count == -1) {
//			GetComponent<SkinnedMeshRenderer> ().enabled = false;
//		}
	}
}
