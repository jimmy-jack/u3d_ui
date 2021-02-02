using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TurnRight : MonoBehaviour,IPointerDownHandler,IPointerUpHandler
{
    public GameObject tank;
    public float speedRotation = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //tank.transform.Translate(-tank.transform.right * speed * Time.deltaTime, Space.World);
        tank.transform.Rotate(Vector3.up * Time.deltaTime * speedRotation, Space.Self);
	}

    public void OnPointerDown(PointerEventData eventData)
    {
        //throw new NotImplementedException();
        speedRotation = 30;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        //throw new NotImplementedException();
        speedRotation = 0;
    }
}