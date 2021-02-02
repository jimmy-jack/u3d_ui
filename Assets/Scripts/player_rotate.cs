using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_rotate : MonoBehaviour {

    public float rotate_speeed = 10;
	// Update is called once per frame
	void Update () {
        transform.Rotate(Vector3.up * Time.deltaTime * rotate_speeed);
	}

    public void OnChangeRotateSpeed(float _speed)
    {
        this.rotate_speeed = _speed;
    }
}
