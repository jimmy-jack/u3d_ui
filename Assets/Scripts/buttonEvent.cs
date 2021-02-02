using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class buttonEvent : MonoBehaviour,IPointerDownHandler,IPointerUpHandler
{

    public Text label = null;

    void Awake()
    {
        transform.GetComponent<Button>().onClick.AddListener(OnClick);
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnClick()
    {
        Debug.Log("Button was  Clicked");
        if(label != null)
        {
            label.text = "Let's Go!";
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("Button was pressed");
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        Debug.Log("Button was released");
    }
}
