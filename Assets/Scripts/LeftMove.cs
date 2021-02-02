using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class LeftMove : MonoBehaviour,IPointerDownHandler,IPointerUpHandler
{
    public GameObject tank;
    public float speed = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		tank.transform.Translate(-tank.transform.right * speed * Time.deltaTime, Space.World);
	}

    public void OnPointerDown(PointerEventData eventData)
    {
        //throw new NotImplementedException();
        speed = 5;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        //throw new NotImplementedException();
        speed = 0;
    }
}