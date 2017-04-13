using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Stepping : MonoBehaviour {
	public Text clock;
	private ClockScript _clock;
	private int step;
	public Text opCodeBox;
	private string opCode;

	//control signals--------------------
	public Toggle t_PCout;
	public Toggle t_MAin;
	public Toggle t_INC4;
	public Toggle t_Cin;
	public Toggle t_Cout;
	public Toggle t_PCin;
	public Toggle t_MDRead;
	public Toggle t_MDout;
	public Toggle t_IRin;
	public Toggle t_Rout;
	public Toggle t_Grb;
	public Toggle t_Ain;

	//buttons ----------------------------
	public Button b_Strobe;
	public Button b_Clear;

	//Scripts ----------------------------
	private Strobing _strobing;
	private Clearing _clearing;



	// Use this for initialization
	void Start () {
		_clock = clock.GetComponent<ClockScript>();
		_strobing = b_Strobe.GetComponent<Strobing> ();
		_clearing = b_Clear.GetComponent<Clearing> ();
	}
	
	// Update is called once per frame
	void Update () {
		opCode = opCodeBox.text;
	}

	public IEnumerator justChill(){
		yield return new WaitForSeconds (.1f);
	}

	public void Step(){
		Debug.Log ("this button has stepped!!");
		step = _clock.getClockVal ();

		switch (step) {
		case 0:
			//PCout, MAin, INC4, Cin, (STROBE), (CLEAR)
			_clearing.clear ();
			/*
			StartCoroutine(justChill());
			t_PCout.isOn = true;
			StartCoroutine(justChill());
			t_Cin.isOn = true;
			StartCoroutine(justChill());
			t_MAin.isOn = true;
			StartCoroutine(justChill());
			t_INC4.isOn = true;
			StartCoroutine(justChill());
			_strobing.strobe ();
			StartCoroutine(justChill());
*/
			busScript.busVal = PCscript.pcVal;
			MAscript.maVal = busScript.busVal;
			ALUScript.ALUVal = busScript.busVal;
			ALUScript.ALUVal += 4;
			Cscript.cVal = ALUScript.ALUVal;
			_strobing.strobe ();
			
			break;
		case 1:
			//Cout, PCin, Read, (STROBE), (CLEAR)
			_clearing.clear ();

			StartCoroutine(justChill());
			busScript.busVal = Cscript.cVal;
			StartCoroutine(justChill());
			t_MDRead.isOn = true;
			StartCoroutine(justChill());
			t_PCin.isOn = true;
			StartCoroutine(justChill());
			_strobing.strobe ();
			StartCoroutine(justChill());

			break;
		case 2:
			//MDout, IRin, (STROBE), (CLEAR)
			_clearing.clear ();

			StartCoroutine(justChill());
			t_MDout.isOn = true;
			StartCoroutine(justChill());
			t_IRin.isOn = true;
			StartCoroutine(justChill());
			busScript.busVal = MDscript.mdVal;
			StartCoroutine(justChill());
			InstructionScript.instructionVal = busScript.busVal;
			StartCoroutine(justChill());
			_strobing.strobe ();
			StartCoroutine(justChill());
			break;
		case 3:
			_clearing.clear ();
			StartCoroutine(justChill());
			switch (opCode) {
			case "12":		//ADD
				t_Rout.isOn = true;
				StartCoroutine(justChill());
				t_Grb.isOn = true;
				StartCoroutine(justChill());
				t_Ain.isOn = true;
				StartCoroutine(justChill());
				break;
			case "1":		//SUB
				break;
			case "2":		//ADDI
				break;
			case "3":		//AND
				break;
			case "4":		//OR
				break;
			case "5":		//SHR
				break;
			case "6":		//SHRA
				break;
			case "7":		//SHL
				break;
			case "8":		//SHC
				break;
			case "9":		//NOT
				break;
			case "10":		//NEG
				break;
			}
			_strobing.strobe ();
			StartCoroutine(justChill());
			break;

		case 4:
			switch (opCode) {
			case "12":		//ADD

				break;
			case "1":		//SUB
				break;
			case "2":		//ADDI
				break;
			case "3":		//AND
				break;
			case "4":		//OR
				break;
			case "5":		//SHR
				break;
			case "6":		//SHRA
				break;
			case "7":		//SHL
				break;
			case "8":		//SHC
				break;
			case "9":		//NOT
				break;
			case "10":		//NEG
				break;
			}
			break;
		}
	}
}
