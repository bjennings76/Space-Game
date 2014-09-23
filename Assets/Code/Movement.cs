using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

	// Use this for initialization
	void Start () {
		rigidbody2D.AddForceAtPosition (-Vector2.right * 5, new Vector2 (1, 1));
		rigidbody2D.AddForce(-Vector2.right, ForceMode2D.Impulse);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
