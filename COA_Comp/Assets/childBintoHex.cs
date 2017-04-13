using UnityEngine;
using UnityEngine.UI;
using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

public class childBintoHex : MonoBehaviour {
	private GameObject child;
	private Text parentTxt;
	private string childBinVal;
	private string childHexVal;
	private int parentDecVal;

	// Use this for initialization
	void Start () {
		child = this.gameObject.transform.GetChild (0).gameObject;
		parentTxt = this.gameObject.GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		childBinVal = child.GetComponent<Text> ().text;
		childHexVal = Convert.ToInt32(childBinVal, 2).ToString("X");

		parentDecVal = int.Parse (childHexVal, System.Globalization.NumberStyles.HexNumber);
		parentTxt.text = parentDecVal.ToString ();
	}
}
