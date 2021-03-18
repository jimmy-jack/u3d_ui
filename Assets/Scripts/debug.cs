using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class debug : MonoBehaviour ,IDragHandler,IBeginDragHandler,IEndDragHandler{

    Vector3 localPos;
    Vector3 worldPos;
    Vector3 transPos;
    public GameObject target;
    private Vector3 targetPos;

     //dragMove------------------
    public GameObject go_dragMove;
    private Transform tf_dragMove;
    bool isDrag;
    float UI_z;
    Vector3 mousePos_drag;
    Vector3 mousePos_beginDrag;
    Vector3 mousePos_endDrag;
    Vector3 offset;
    //---------------------------

	// Use this for initialization
	void Start () {
        localPos = transform.localPosition;
        worldPos = transform.position;
        transPos = transform.InverseTransformPoint(worldPos);//transform.position;

        //dragMove
        tf_dragMove = go_dragMove.GetComponent<Transform>();
        isDrag = false;
        UI_z = tf_dragMove.position.z;
       // Debug.Log(UI_z);        //100

        //Debug.Log(gameObject + "localPos = " + localPos);
        //Debug.Log(gameObject + "worldPos = " + worldPos);
        //Debug.Log(gameObject + "transPos = " + transPos);
	}
	
	// Update is called once per frame
	void Update () {
        //transform.Translate(Vector3.forward * Time.deltaTime, Space.Self);
        //transform.Rotate(Vector3.forward * Time.deltaTime * 10,Space.Self);
        // transform.RotateAround(worldPos, Vector3.forward , Time.deltaTime * 10);
        if(target != null)
        {
            targetPos = target.transform.position;
            transform.LookAt(targetPos);

            Vector3 mousePos = Input.mousePosition;
            // Debug.Log(mousePos);
            Vector3 mousePos_ViewPort = Camera.main.ScreenToViewportPoint(new Vector3(mousePos.x,mousePos.y,100));
            //Debug.Log(mousePos_ViewPort);
            Vector3 mousePos_World = Camera.main.ScreenToWorldPoint(new Vector3(mousePos.x,mousePos.y,100));
            //Debug.Log(mousePos_World);
        }
        

        if(isDrag)
        {
            tf_dragMove.position = mousePos_drag + offset;
            Debug.Log("----------------" + tf_dragMove.position);
        }
        //Debug.Log(tf_dragMove);
	}

    public void OnDrag(PointerEventData eventData)
    {
        //throw new NotImplementedException();
        isDrag = true;
        mousePos_drag = Camera.main.ScreenToWorldPoint(new Vector3(eventData.position.x, eventData.position.y, UI_z));
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        //throw new NotImplementedException();
        isDrag = true;
        mousePos_beginDrag =  Camera.main.ScreenToWorldPoint(new Vector3(eventData.position.x, eventData.position.y, UI_z));
        offset = tf_dragMove.position - mousePos_beginDrag;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        //throw new NotImplementedException();
         isDrag = false;
         //mousePos_endDrag =  Camera.main.ScreenToWorldPoint(new Vector3(eventData.position.x, eventData.position.y, UI_z));
    }
}
