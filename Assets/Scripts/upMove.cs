using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class upMove : MonoBehaviour,IPointerDownHandler,IPointerUpHandler,IDragHandler
{
    public GameObject tank;
    public float speed = 0;
    private Vector2 offsetPos;

    // Use this for initialization
    void Start () {
        //GameObject a = new GameObject("Sphere");
        //GameObject.Instantiate(tank,new Vector3(10,0,0),transform.rotation);
	}
	
	// Update is called once per frame
	void Update () {
        //Debug.Log(Time.deltaTime);
        //tank.transform.position += transform.forward * Time.deltaTime;
        tank.transform.Translate(tank.transform.forward * speed * Time.deltaTime, Space.World);
        //GameObject temp = new GameObject("Sphere");
        //temp.transform.Translate(Vector3.forward * speed, Space.World);
	}

    public void OnPointerDown(PointerEventData eventData)
    {
        //throw new NotImplementedException();
        speed = 5;
        //offsetPos = eventData.position - (Vector2)transform.position;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        //throw new NotImplementedException();
        speed = 0;
    }

    public void OnDrag(PointerEventData eventData)
    {
        //throw new NotImplementedException();
        //transform.position = eventData.position - offsetPos;
        ;
    }
}
