using UnityEngine;
using System.Collections;

public class test_02A : MonoBehaviour {

	private static int sumCount;

	// Use this for initialization
	void Start () {
		GetComponent<SkinnedMeshRenderer> ().enabled = false;
	}

	// Update is called once per frame
	void Update () {
		sumCount = GpsSignal.count;
		print (sumCount);
		bool oddeven = Mathf.FloorToInt(Time.time) % 2 == 0;
		//shatter
		if (sumCount == 0) {
			GetComponent<SkinnedMeshRenderer> ().enabled = oddeven;
			//refocus
		} else if (sumCount == -1) {
			GetComponent<SkinnedMeshRenderer> ().enabled = false;
		}
	}
}
