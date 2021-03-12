using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BenMove : MonoBehaviour {

    private Animator anim;
    //private int speedID = Animator.StringToHash("Speed");
    //private int isSpeedUpID = Animator.StringToHash("IsSpeedUp");
    //private int turnID = Animator.StringToHash("Horizontal");


    private int speedRotateID = Animator.StringToHash("SpeedRotate");
    private int speedZID = Animator.StringToHash("SpeedZ");
    private int isVaultID = Animator.StringToHash("IsVault");
    private int jumpHID = Animator.StringToHash("JumpH");

    private Vector3 MatchPoint;
    private CharacterController cctrol;

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
        cctrol = GetComponent<CharacterController>();
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

        bool bIsVault = false;
        if(/*anim.GetFloat(speedZID) > 2*/anim.GetCurrentAnimatorStateInfo(0).IsName("LocalMotion"))
        {
            RaycastHit hit;
            //Vector3 point = transform.position;
            if(Physics.Raycast(transform.position + Vector3.up * 0.3f , transform.forward, out hit, 4f))
            {
                if(hit.distance > 3)
                {
                    Vector3 point = hit.point;
                    point.y = hit.collider.transform.position.y + hit.collider.bounds.size.y + 0.05f;
                    MatchPoint = point;
                    bIsVault = true; 
                }
            }
        }
        anim.SetBool(isVaultID, bIsVault);
        if(anim.GetCurrentAnimatorStateInfo(0).IsName("Vault"))
        {
            anim.MatchTarget(MatchPoint, Quaternion.identity, AvatarTarget.LeftHand, new MatchTargetWeightMask(Vector3.one, 0), 0.3f, 0.45f);
        }

        cctrol.enabled = anim.GetFloat(jumpHID) < 0.05;

	}
}
