using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Clearing : MonoBehaviour {
	public Toggle t_PCin;
	public Toggle t_PCout;
	public Toggle t_Cin;
	public Toggle t_Cout;
	public Toggle t_Rin;
	public Toggle t_Rout;
	public Toggle t_MDin;
	public Toggle t_MDout;
	public Toggle t_MDRead;
	public Toggle t_MDWrite;
	public Toggle t_Gra;
	public Toggle t_Grb;
	public Toggle t_Grc;
	public Toggle t_INC4;
	public Toggle t_ADD;
	public Toggle t_ADDI;
	public Toggle t_Br;
	public Toggle t_IRin;
	public Toggle t_BAout;
	public Toggle t_c1out;
	public Toggle t_c2out;
	public Toggle t_MAin;
	public Toggle t_Ain;
	public Toggle t_SUB;
	public Toggle t_AND;
	public Toggle t_OR;
	public Toggle t_SHR;
	public Toggle t_SHRA;
	public Toggle t_SHL;
	public Toggle t_SHC;
	public Toggle t_NOT;
	public Toggle t_NEG;
	public Toggle t_CB;
	public Toggle t_END;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void clear(){
		Debug.Log ("This button has cleared!");
		t_PCin.isOn = false;
		t_PCout.isOn = false;
		t_Cin.isOn = false;
		t_Cout.isOn = false;
		t_Rin.isOn = false;
		t_Rout.isOn = false;
		t_MDin.isOn = false;
		t_MDout.isOn = false;
		t_MDRead.isOn = false;
		t_MDWrite.isOn = false;
		t_Gra.isOn = false;
		t_Grb.isOn = false;
		t_Grc.isOn = false;
		t_INC4.isOn = false;
		t_ADD.isOn = false;
		t_ADDI.isOn = false;
		t_Br.isOn = false;
		t_IRin.isOn = false;
		t_BAout.isOn = false;
		t_c1out.isOn = false;
		t_c2out.isOn = false;
		t_MAin.isOn = false;
		t_Ain.isOn = false;
		t_SUB.isOn = false;
		t_AND.isOn = false;
		t_OR.isOn = false;
		t_SHR.isOn = false;
		t_SHRA.isOn = false;
		t_SHL.isOn = false;
		t_SHC.isOn = false;
		t_NOT.isOn = false;
		t_NEG.isOn = false;
		t_CB.isOn = false;
		t_END.isOn = false;
	}
}
