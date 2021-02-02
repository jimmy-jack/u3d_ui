using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Skill : MonoBehaviour {

    public float coldTime = 2;
    private bool bIsStartTime = false;
    private Image img_mask;
    private float timer = 0;
    public KeyCode keycode;
	// Use this for initialization
	void Start () {
        img_mask = transform.Find("mask").GetComponent<Image>();
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetKeyDown(keycode))
        {
            bIsStartTime = true;
        }
	    if(bIsStartTime)
        {
            timer += Time.deltaTime;
            img_mask.fillAmount = (coldTime - timer) / coldTime;
            if(timer >= coldTime)
            {
                timer = 0;
                bIsStartTime = false;
            }
        }
	}

    public void OnClicked()
    {
        bIsStartTime = true;
    }
}
