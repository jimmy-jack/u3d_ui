using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class levelSelect : MonoBehaviour,IBeginDragHandler, IEndDragHandler{

    public float smoothRate = 4;
    private ScrollRect scrollRect;
    private float[] hPos = new float[]{0,0.5f,1f }; //
    private bool IsDrag;
    private int pos;
    public Toggle[] toogleArr;

    public void OnBeginDrag(PointerEventData eventData)
    {
        IsDrag = true;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        IsDrag = false;
        pos = 0;
        float distance = Math.Abs(scrollRect.horizontalNormalizedPosition - hPos[pos]);
        for(int i = 1;i < hPos.Length;++i)
        {
            float temp_dis = Math.Abs(scrollRect.horizontalNormalizedPosition - hPos[i]);
            if(temp_dis < distance)
            {
                temp_dis = distance;
                pos = i;
            }
        }

    }

	// Use this for initialization
	void Start () {
        scrollRect = GetComponent<ScrollRect>();
	}
	
	// Update is called once per frame
	void Update () {
        if(!IsDrag)
        {
            //scrollRect.horizontalNormalizedPosition = hPos[pos];
            scrollRect.horizontalNormalizedPosition = Mathf.Lerp(scrollRect.horizontalNormalizedPosition, hPos[pos], Time.deltaTime * smoothRate);
        }
        toogleArr[pos].isOn = true;
	}

    public void MoveToPageX(int page)
    {
        pos = page - 1;
    }
}
