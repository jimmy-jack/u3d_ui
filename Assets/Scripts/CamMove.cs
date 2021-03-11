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
        offset = transform.position - player.position;
	}
	
	// Update is called once per frame
	void LateUpdate () {
        Vector3 targetPos = player.position + player.TransformDirection(offset);

        //跟随
        transform.position = Vector3.Lerp(transform.position, targetPos, Time.deltaTime * smoothness);
        transform.LookAt(player);
	}
}
