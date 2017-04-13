using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections;

public class FullInstructionBinScript : MonoBehaviour {
	public Text decInstruction;
	private FullInstructionDecScript _fids;
	private int decVal;
	private string binaryString;
	public Text binInstruction;

	public Text op;
	public Text ra;
	public Text rb;
	public Text rc;
	public Text c1;
	public Text c2;
	public Text c3;
	private string edit;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		_fids = decInstruction.GetComponent<FullInstructionDecScript> ();

		decVal = _fids.dec;
		binaryString = Convert.ToString (decVal, 2).PadLeft(32, '0');
		binInstruction.text = binaryString;

		edit = binInstruction.text;
		op.text = edit.Substring(0,5);
		ra.text = edit.Substring(5,5);
		rb.text = edit.Substring(10,5);
		rc.text = edit.Substring(15,5);
		c1.text = edit.Substring (20, 4);
		c2.text = edit.Substring (24, 4);
		c3.text = edit.Substring (28, 4);
	}
}
