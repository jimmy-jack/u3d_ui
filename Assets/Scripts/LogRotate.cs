using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogRotate : MonoBehaviour {

    private Transform ts;
	// Use this for initialization
	void Start () {
        ts = GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
        ts.Rotate(Vector3.up, 90f * Time.deltaTime);
	}
}
