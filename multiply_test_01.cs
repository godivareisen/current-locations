using UnityEngine;
using System.Collections;

public class multiply_test_01 : MonoBehaviour {

	int count = 0;
	public GameObject ghost01;

	// Use this for initialization
	void Start () {
		ghost01 = GameObject.FindWithTag ("ghost");
	}

	//	 Update is called once per frame
	void Update () {
		if (count == 0) {
			print ("one person");
		} else if (count >= 1) {
			print ("add ppl");
		}
	}

	void OnTriggerEnter(Collider col) {
		if (col.gameObject.tag == "person") {
			count++;
			if (count == 1) {
				Instantiate (ghost01, new Vector3 (0, 2, 0), Quaternion.identity);
				Instantiate (ghost01, new Vector3 (2, 0, 4), Quaternion.identity);
			} else if (count == 2) {
				Instantiate (ghost01, new Vector3 (0, 4, 0), Quaternion.identity);
				Instantiate (ghost01, new Vector3 (4, 0, 0), Quaternion.identity);
			}
			print ("hit");
			print (count);
		}
	}
		
}
