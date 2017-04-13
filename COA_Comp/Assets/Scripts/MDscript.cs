using UnityEngine;
using UnityEngine.UI;
using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

public class MDscript : MonoBehaviour {


	static public int mdVal = 0;
	static public string mdString = "0";
	public Text mdtxt;

	// Use this for initialization
	void Start () {


	}

	// Update is called once per frame
	void Update () {
		mdVal = int.Parse (mdString, System.Globalization.NumberStyles.HexNumber);
		Debug.Log (mdVal);
		mdtxt.text = "MD " + mdString;
	}
		
}
