using UnityEngine;
using System.Collections;

public class MyReplay : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

public struct MyKeyFrame{
	public float frameTime;
	public Vector3 position;
	public Quaternion rotation;

	public MyKeyFrame (float t, Vector3 p, Quaternion r){
		t = frameTime;
		p = position;
		r = rotation;
	}
}