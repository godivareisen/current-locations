using UnityEngine;
using System.Collections;

public class multiply_test_02 : MonoBehaviour {

	int count = 0;
	public GameObject[] visibleList;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (count >= 1) {
			print ("spawn ghosts");
		}
	}

	void OnTriggerEnter (Collider col) {
//		if (visibleList == null) {
//			visibleList = GameObject.FindGameObjectsWithTag ("ghost");
//		}
		if (col.gameObject.tag == "person") {
//			foreach (GameObject visible in visibleList) {
//				visible.GetComponent<SkinnedMeshRenderer> ().enabled = true;
//			}
//			count++;
			print ("hit");
		}
	}
}
