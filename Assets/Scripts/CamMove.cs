using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMove : MonoBehaviour {

    private Transform player;
    private Vector3 offset;
    private int smoothness = 3;

	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        offset = transform.position - player.position;  //相对
        //Debug.Log("InitOffset = " + offset);
	}
	
	// Update is called once per frame
	void LateUpdate () {
        Vector3 targetPos = player.position + player.TransformDirection(offset);

        if(Input.GetKey(KeyCode.Space))
        {
            Debug.Log("localOffset = " + offset);
            Debug.Log("globalOffset = " + player.TransformDirection(offset));
        }


        //跟随(跟着移动，跟着旋转)
        transform.position = Vector3.Lerp(transform.position, targetPos, Time.deltaTime * smoothness);
        transform.LookAt(player);
	}
}
