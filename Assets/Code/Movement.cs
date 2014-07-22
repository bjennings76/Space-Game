using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

	// Use this for initialization
	void Start () {
	rigidbody2D.AddForce(-Vector2.right, ForceMode2D.Impulse);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
