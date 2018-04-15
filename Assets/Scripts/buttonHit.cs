using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using btm = ButtonManager;


public class buttonHit : MonoBehaviour {

	//private btm myButtonManager = GameObject.Find("piano_v02").GetComponent<btm>();
	//public GameObject pianoParent;
	//private static ButtonManager myButtonManager = pianoParent.GetComponent<ButtonManager>();
	private ButtonManager myBut; 
	public int indexNum;

	// Use this for initialization
	void Start () {
		myBut = GameObject.Find("piano_v02").GetComponent<ButtonManager>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other) {
        myBut.SetCurrentButton(indexNum);

    }
    void OnTriggerStay(Collider other) {
        

    }
    void OnTriggerExit(Collider other) {
        

    }
}
