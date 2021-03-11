using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BenMove : MonoBehaviour {

    private Animator anim;
    private int speedID = Animator.StringToHash("Speed");
    private int isSpeedUpID = Animator.StringToHash("IsSpeedUp");
    private int turnID = Animator.StringToHash("Horizontal");


    private int speedRotateID = Animator.StringToHash("SpeedRotate");
    private int speedZID = Animator.StringToHash("SpeedZ");

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        //anim.SetFloat("Speed", Input.GetAxis("Vertical"));
        //anim.SetFloat(speedID, Input.GetAxis("Vertical"));
        //anim.SetFloat(turnID, Input.GetAxis("Horizontal"));
        //if(Input.GetKeyDown(KeyCode.LeftShift))
        //{
        //    anim.SetBool(isSpeedUpID, true);
        //}
        //if(Input.GetKeyUp(KeyCode.LeftShift))
        //{
        //    anim.SetBool(isSpeedUpID, false);
        //

        //anim.SetFloat(speedID, Input.GetAxis("Vertical") * 3.551f);


        anim.SetFloat(speedZID, Input.GetAxis("Vertical") * 3.551f);
        anim.SetFloat(speedRotateID, Input.GetAxis("Horizontal") * 2.2f);
	}
}
