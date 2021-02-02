using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragMove : MonoBehaviour,IDragHandler,IPointerDownHandler,IPointerUpHandler
{
    //public Vector3 pos = new Vector2();
    private Vector3 offset = Vector3.zero;
    private float z;
    public void OnDrag(PointerEventData eventData)
    {
        //RectTransformUtility.ScreenPointToWorldPointInRectangle(GetComponent<RectTransform>(), eventData.position,
        //    Camera.main, out pos);
        //transform.position=pos;
        Vector3 v_new = new Vector3(eventData.position.x, eventData.position.y, z);
        transform.position = Camera.main.ScreenToWorldPoint(v_new) + offset;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        z = Camera.main.WorldToScreenPoint(transform.position).z;
        Vector3 v_new = new Vector3(eventData.position.x, eventData.position.y, z);
        offset = transform.position - Camera.main.ScreenToWorldPoint(v_new);
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        throw new NotImplementedException();
    }


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
