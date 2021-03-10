using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {

    private Animator ani;
	// Use this for initialization
	void Start () {
        ani = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        float v = Input.GetAxisRaw("Vertical");
        ani.SetInteger("Vertical", (int)v);
        transform.Translate(Vector3.forward * v * Time.deltaTime * 3);
	}
}
