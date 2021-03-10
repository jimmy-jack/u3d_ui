using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class musicOn : MonoBehaviour {

    private Toggle toogle;
    public GameObject toogleOn;
    public GameObject toogleOff;
	// Use this for initialization
	void Start () {
        toogle = GetComponent<Toggle>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnToggleValueChange(bool isOn)
    {
        toogleOn.SetActive(isOn);
        toogleOff.SetActive(!isOn);
    }
}
