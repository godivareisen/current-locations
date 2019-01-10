using UnityEngine;
using System.Collections;

public class playerController : MonoBehaviour {

	public float moveSpeed = 5;
	private Vector3 moveDir;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		moveDir = new Vector3 (Input.GetAxisRaw ("Horizontal"), 0, Input.GetAxisRaw ("Vertical")).normalized;
	}

	void FixedUpdate() {
		GetComponent<Rigidbody> ().MovePosition (GetComponent<Rigidbody> ().position + transform.TransformDirection(moveDir) * moveSpeed * Time.deltaTime);
	}
}
