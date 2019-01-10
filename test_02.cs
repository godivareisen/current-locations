using UnityEngine;
using System.Collections;

public class test_02 : MonoBehaviour {

	private static int sumCount;

	// Use this for initialization
	void Start () {
		GetComponent<SkinnedMeshRenderer> ().enabled = false;
	}

	// Update is called once per frame
	void Update () {
		sumCount = GpsSignal.count;
		print (sumCount);
		//shatter
		if (sumCount == 0) {
			GetComponent<SkinnedMeshRenderer> ().enabled = true;
		//refocus
		} else if (sumCount == -1) {
			GetComponent<SkinnedMeshRenderer> ().enabled = false;
		}
	}
}
