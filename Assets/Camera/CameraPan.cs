using UnityEngine;
using System.Collections;

public class CameraPan : MonoBehaviour {

	private GameObject playerObject;

	// Use this for initialization
	void Start () {
		playerObject = GameObject.FindGameObjectWithTag("Player");
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.LookAt (playerObject.transform.position);
	}
}
