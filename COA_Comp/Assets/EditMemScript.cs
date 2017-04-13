using System;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class EditMemScript : MonoBehaviour {
	public InputField MemLoc;
	public InputField memVal;

	private string memLocStr;
	private string memValStr;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void EditTheMemory(){
		memLocStr = MemLoc.text;
		memValStr = memVal.text;

		int memLocInt = Int32.Parse (memLocStr);


		Debug.Log("The fields contain the strings " + memLocStr + " and " + memValStr);
		MemoryScript.memList [memLocInt].hexByte = memValStr;
	}
}
