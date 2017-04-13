using UnityEngine;
using UnityEngine.UI;
using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;


public class busScript : MonoBehaviour {
	public Toggle t_PCout;
	public Toggle t_MDout;
	public Toggle t_Rout;
	public Toggle t_Cout;
	public Toggle t_BAout;
	public Toggle t_c1out;
	public Toggle t_c2out;

	public Text Cout;
	public Text PCout;
	public Text Sel_Reg_Val;
	public Text busTxt;
	public Text MDout;
	public GameObject registers;

	public Text selRegBox;
	private string selReg;
	private string selRegVal;

	public Text registerABox;
	public Text registerBBox;
	public Text registerCBox;

	private Cscript _cS;
	public static int busVal;
	public static int md;
	public static int c;
	public static int r;
	public static int pc;
	private int selRegValDec;
	private int selRegLoc;

	private Text regChild;

	// Use this for initialization
	void Start () {
		
	
	}
	
	// Update is called once per frame
	void Update () {
		selReg = selRegBox.text;

		if (t_PCout.isOn) {
			pc = PCscript.pcVal;
		} else {
			pc = 0;
		}

		if (t_MDout.isOn) {
			md = MDscript.mdVal;
		}else {
			md = 0;
		}

		if (t_Cout.isOn) {
			c = Cscript.cVal;
		}else {
			c = 0;
		}

		if (t_Rout.isOn) {
			string s;
			switch (selReg) {
			case "a":
				selRegVal = registerABox.text;
				selRegLoc = Int32.Parse (selRegVal);
				regChild = registers.gameObject.transform.GetChild (selRegLoc).GetComponent<Text> ();
				s = regChild.text;
				selRegValDec = Int32.Parse (s);
				break;
			case "b":
				selRegVal = registerBBox.text;
				selRegLoc = Int32.Parse (selRegVal);
				regChild = registers.gameObject.transform.GetChild (selRegLoc).GetComponent<Text> ();
				s = regChild.text;
				selRegValDec = Int32.Parse (s);
				break;
			case "c":
				selRegVal = registerCBox.text;
				selRegLoc = Int32.Parse (selRegVal);
				regChild = registers.gameObject.transform.GetChild (selRegLoc).GetComponent<Text> ();
				s = regChild.text;
				selRegValDec = Int32.Parse (s);
				break;
			}
		} else {
			selRegValDec = 0;
		}


		busVal = (pc + md + c + r + selRegValDec);

		busTxt.text = "Bus " + busVal.ToString();

	}

	public int getBusVal(){
		return busVal;
	}
}
