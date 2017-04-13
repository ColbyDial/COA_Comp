using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class InstructionScript : MonoBehaviour {


	static public int instructionVal = 0;
	public Text instructiontxt;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		instructiontxt.text = "" + instructionVal.ToString ("X8");
	}
}
