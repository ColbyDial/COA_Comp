using UnityEngine;
using UnityEngine.UI;
using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

public class Strobing : MonoBehaviour {
	//takes what is on the bus and puts it into whatever is "IN"
	public Toggle t_PCin;
	public Toggle t_MDin;
	public Toggle t_MDRead;
	public Toggle t_MAin;
	public Toggle t_Ain;
	public Toggle t_IRin;
	public Toggle t_Br;
	public Toggle t_CB;
	public Toggle t_Cin;
	public Toggle t_Rin;
	public Toggle t_END;
	public Toggle t_INC4;
	public Toggle t_ADD;
	public Toggle t_Rout;
	public Toggle t_SUB;
	public Text clock;
	private ClockScript _clock;

	public Button b_clear;
	private Clearing s_clear;

	public Text selRegBox;
	private string selReg;
	private string selRegVal;
	private int selRegValDec;
	private int selRegLoc;
	private Text regChild;
	public GameObject registers;

	public Text registerABox;
	public Text registerBBox;
	public Text registerCBox;

	//public int clockVal = 0;
	// Use this for initialization
	void Start () {
		//clock.text = "Clock: " + clockVal.ToString ();
		_clock = clock.GetComponent<ClockScript>();
		s_clear = b_clear.GetComponent<Clearing> ();

	}
	
	// Update is called once per frame
	void Update () {
		selReg = selRegBox.text;
	}

	public void strobe(){
		Debug.Log ("The button has been strobed!!");

		if (t_PCin.isOn) {
			PCscript.pcVal = busScript.busVal;
		}

		if (t_MDin.isOn) {
			MDscript.mdString = busScript.busVal.ToString();
		}

		if (t_MAin.isOn) {
			MAscript.maVal = busScript.busVal;
		}

		if (t_Cin.isOn) {
			Cscript.cVal = ALUScript.ALUVal;   
		}

		if (t_Ain.isOn) {
			Ascript.aVal = busScript.busVal;
		}

		if (t_Rin.isOn) {
			switch (selReg) {
			case "a":
				selRegVal = registerABox.text;
				selRegLoc = Int32.Parse (selRegVal);
				regChild = registers.gameObject.transform.GetChild (selRegLoc).GetComponent<Text> ();
				regChild.text = busScript.busVal.ToString ();
				break;
			case "b":
				selRegVal = registerABox.text;
				selRegLoc = Int32.Parse (selRegVal);
				regChild = registers.gameObject.transform.GetChild (selRegLoc).GetComponent<Text> ();
				regChild.text = busScript.busVal.ToString ();
				break;
			case "c":
				selRegVal = registerABox.text;
				selRegLoc = Int32.Parse (selRegVal);
				regChild = registers.gameObject.transform.GetChild (selRegLoc).GetComponent<Text> ();
				regChild.text = busScript.busVal.ToString ();
				break;
			}
		}

		if (t_IRin.isOn) {
			InstructionScript.instructionVal = busScript.busVal;
		}
			

	// Read and Write from memory --------------------------------------------------------
		if (t_MDRead.isOn) {
			MDscript.mdString = MemoryScript.memList [MAscript.maVal].hexWord;
		}

	// ALU codes -------------------------------------------------------------------------
		if (t_INC4.isOn) {
			ALUScript.ALUVal = busScript.busVal;
			ALUScript.ALUVal += 4;
			if (t_Cin.isOn) {
				Cscript.cVal = ALUScript.ALUVal;   
			}
		}
		if (t_ADD.isOn) {
			ALUScript.ALUVal = busScript.busVal;
			ALUScript.ALUVal += Ascript.aVal;
			if (t_Cin.isOn) {
				Cscript.cVal = ALUScript.ALUVal;
			}
		}
		if (t_SUB.isOn) {
			ALUScript.ALUVal = busScript.busVal;
			ALUScript.ALUVal -= Ascript.aVal;
			if (t_Cin.isOn) {
				Cscript.cVal = ALUScript.ALUVal;
			}
		}


	//Ending Code ------------------------------------------------------------------------
		if (t_END.isOn) {
			_clock.clearClock ();
			s_clear.clear ();

		} else {
			if (t_END.isOn == false) {
				_clock.incClock ();
			}
		}

		s_clear.clear ();

	}


}
