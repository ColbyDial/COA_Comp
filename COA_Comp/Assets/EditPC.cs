using System;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class EditPC : MonoBehaviour {
	public InputField PCVal;

	private string pcVal;
	private int pcInt;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void EditThePCVal(){
		pcVal = PCVal.text;
		pcInt = Int32.Parse (pcVal);
		PCscript.pcVal = pcInt;
	}
}
